using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioNivel : MonoBehaviour
{
    public Image Barra;
    AsyncOperation Operation;

    public void CargarEscena(int nivel) 
    {
        StartCoroutine(Cargando(nivel));
    }

    IEnumerator Cargando(int nivel)
    {
        Operation = SceneManager.LoadSceneAsync(nivel);

        while(!Operation.isDone)
        {
            Barra.fillAmount = Operation.progress;
            yield return null;
        }
    }
}
