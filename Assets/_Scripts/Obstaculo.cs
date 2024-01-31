using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Jugador"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
