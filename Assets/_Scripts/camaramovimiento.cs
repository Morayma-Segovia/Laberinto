using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaramovimiento : MonoBehaviour
{

    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + new Vector3((float)-0.2, (float)0.6, (float)-1);
    }
}
