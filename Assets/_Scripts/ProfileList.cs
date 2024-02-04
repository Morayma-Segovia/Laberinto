using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfileLis : MonoBehaviour
{
    public Transform profilesHolder;
    public GameObject profileUIBoxPrefab;

    void Start()
    {
        var index = ProfileStorage.GetProfileIndex();
        foreach(var profileName in index.profileFileNames)
        {
            var go = Instantiate(this.profileUIBoxPrefab);
            var uibox = go.GetComponent<ProfileBoxUI>();

            uibox.nameLabel.text = profileName;

            uibox.loadBtn.onClick.AddListener(() =>
            {
                ProfileStorage.LoadProfile(profileName);
                SceneManager.LoadScene("Nivel1");
            });

            uibox.deleteBtn.onClick.AddListener(() =>
            {
                ProfileStorage.DeleteProfile(profileName);
                Destroy(go);
            });
            go.transform.SetParent(this.profilesHolder, false);

        }
    }
}
