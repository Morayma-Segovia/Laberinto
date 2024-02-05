using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileSpawner : MonoBehaviour
{
    public Transform newGameSpawn;
    public GameObject playerPreFab;

    // Start is called before the first frame update
    void Start()
    {
        if(ProfileStorage.s_currentProfile == null || ProfileStorage.s_currentProfile.newGame)
        {
            Instantiate(this.playerPreFab, this.newGameSpawn.position, Quaternion.identity);
        }
        else
        {
            float x = ProfileStorage.s_currentProfile.x;
            float y = ProfileStorage.s_currentProfile.y;
            float z = ProfileStorage.s_currentProfile.z;

            int monedas = ProfileStorage.s_currentProfile.monedas;

            Vector3 pos = new Vector3 (x, y, z);
            Instantiate(this.playerPreFab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
