using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuradarPersonaje : MonoBehaviour
{
    public bool Celeste;
    public bool Rosa;
    public bool Morado;
    public bool Blanco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Blanco = PlayerPrefs.GetInt("PersonajeBlanco") == 1;
        Celeste = PlayerPrefs.GetInt("PersonajeCeleste") == 1;
        Morado = PlayerPrefs.GetInt("PersonajeMorado") == 1;
        Rosa = PlayerPrefs.GetInt("PersonajeRosa") == 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Celeste==false && Rosa==false && Morado==false && Blanco == false)
        {
            Blanco = true;
        }
        
    }
    public void PersonajeCeleste()
    {
        Celeste = true;
        Rosa = false; 
        Morado = false;
        Blanco = false;
        guardar();
    }
    public void PersonajeRosa()
    {
        Rosa = true;
        Celeste = false;
        Morado=false;
        Blanco = false;
        guardar();
    }
    public void PersonajeMorado()
    {
        Morado = true;
        Celeste=false;
        Rosa=false;
        Blanco=false;
        guardar();
    }
    public void PersonajeBlanco()
    {
        Blanco = true;
        Celeste = false;
        Rosa=false;
        Morado=false;
        guardar();
    }
    public void guardar()
    {
        PlayerPrefs.SetInt("PersonajeBlanco", Blanco ? 1 : 0);
        PlayerPrefs.SetInt("PersonajeCeleste", Celeste ? 1 : 0);
        PlayerPrefs.SetInt("PersonajeMorado", Morado ? 1 : 0);
        PlayerPrefs.SetInt("PersonajeRosa", Rosa ? 1 : 0);
    }
}
