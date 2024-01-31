using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargaNombre : MonoBehaviour
{
    private GameObject nombre1;
    // Start is called before the first frame update
    void Start()
    {
        nombre1 = GameObject.FindGameObjectWithTag("nombre1");
        nombre1.GetComponent<Text>().text = PlayerPrefs.GetString("nombre1");
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
