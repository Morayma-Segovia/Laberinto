using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Selectname : MonoBehaviour
{

    public InputField inputText;

    public Text textoNombre;

    public Image luz;

    public GameObject botonAceptar;

    public GameObject funciones;

    private void Awake()
       {
          luz.color = Color.red;
      }

     
      void Update()
       {
          if(textoNombre.text.Length<3)
          {
              luz.color= Color.red;
              botonAceptar.SetActive(false);
          }

          if (textoNombre.text.Length >= 3)
          {
              luz.color = Color.green;
              botonAceptar.SetActive(true);
          }
      }

      public void aceptar()
      {
        PlayerPrefs.SetString("nombre1", inputText.text);
        SceneManager.LoadScene("Menu");
        funciones.GetComponent<GuradarPersonaje>().guardar();
      }





}
