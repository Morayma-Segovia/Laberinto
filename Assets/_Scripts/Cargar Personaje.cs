using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarPersonaje : MonoBehaviour
{
    public GameObject BlancoPersonaje;
    public GameObject CelestePersonaje;
    public GameObject MoradoPersonaje;
    public GameObject RosaPersonaje;

    public bool Celeste;
    public bool Rosa;
    public bool Morado;
    public bool Blanco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Blanco = PlayerPrefs.GetInt("PersonajeBlanco") == 1;
        Celeste = PlayerPrefs.GetInt("PersonajeCeleste") == 1;
        Morado = PlayerPrefs.GetInt("PersonajeMorado") == 1;
        Rosa = PlayerPrefs.GetInt("PersonajeRosa") == 1;

        if(Blanco==true)
        {
            BlancoPersonaje.SetActive(true);
            Destroy(CelestePersonaje);
            Destroy(MoradoPersonaje);
            Destroy(RosaPersonaje);
        }
        if (Celeste == true)
        {
            CelestePersonaje.SetActive(true);
            Destroy(BlancoPersonaje);
            Destroy(MoradoPersonaje);
            Destroy(RosaPersonaje);
        }
        if (Morado == true)
        {
            MoradoPersonaje.SetActive(true);
            Destroy(CelestePersonaje);
            Destroy(BlancoPersonaje);
            Destroy(RosaPersonaje);
        }
        if (Rosa == true)
        {
            RosaPersonaje.SetActive(true);
            Destroy(CelestePersonaje);
            Destroy(MoradoPersonaje);
            Destroy(BlancoPersonaje);
        }

    }
}
