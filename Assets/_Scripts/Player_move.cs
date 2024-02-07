using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player_move : MonoBehaviour
{
    public Rigidbody rb;
    public Text score;
    public Text gemas;
    public Text monedasespeciales;
    public Text objetoraro;
    public Text escudos;
    public Text tvictoria;
    public Text XP;
    public Text totalEXP;
    public Text TMonedas;
    public Text TRarezas;
    public Text TGemas;
    public Text TEspeciales;
    public Text textotecla;
    public GameObject cofre;
    public GameObject gemac;
    public GameObject gemacs;
    public int nivel;
    bool esperandoTecla = false;
    bool haSalido;
   
    //public float forwardForce = 2000;
    public float sideForce = 200;
    Vector3 posicionInicial;
    int monedas = 0;
    int gema = 0;
    int escudo=0;
    int raresa= 0;
    int especial = 0;
    int exp= 0;
    public
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posicionInicial= transform.position;
        tvictoria.enabled = false;
        totalEXP.enabled = false;
        TMonedas.enabled = false;
        TRarezas.enabled = false;
        TGemas.enabled = false; 
        TEspeciales.enabled = false;
        haSalido = false;
        cofre.SetActive(false);
        gemac.SetActive(false);
        gemacs.SetActive(false);
        textotecla.enabled = false;




    }

    // Update is called once per frame
    void Update()
    {
     
       if(!haSalido)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            rb.AddForce(new Vector3(horizontal, 0, vertical) * sideForce);
        }
        if (esperandoTecla && Input.anyKeyDown)
        {
            SceneManager.LoadScene(nivel);

            esperandoTecla = false;
        }


        /* 
          rb.AddForce(0, 0, sideForce * Time.deltaTime);

          if (Input.GetKey("d"))
          {
              rb.AddForce(sideForce * Time.deltaTime,0,0);
          }

          if (Input.GetKey("a"))
          {
              rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
          }

          score.text=transform.position.z.ToString("0");
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("salida"))
        {
            haSalido = true;
            tvictoria.enabled=true;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            totalEXP.enabled = true;
            TMonedas.enabled = true;
            TRarezas.enabled = true;
            TGemas.enabled = true;
            textotecla.enabled = true;
            TEspeciales.enabled = true;
            score.enabled = false;
            gemas.enabled = false;
            monedasespeciales.enabled = false;
            objetoraro.enabled = false;
            escudos.enabled = false;
            XP.enabled = false;

            exp = exp + 20;
            totalEXP.text = "Total EXP:" + exp;
            if (monedas >= 5)
            {
                TMonedas.text = "Has recibido una insignia por recolectar: "+monedas+" monedas";
            }

            if (raresa >= 1)
            {
                TRarezas.text = "Has recibido una insignia por recolectar: " + raresa+" objetos raros";
            }

            if (gema >= 2)
            {
                TRarezas.text = "Has recibido una medalla por recolectar: " + gema+" gemas";
            }

            if (especial >= 1)
            {
                exp = exp + 50;
                totalEXP.text = "Total EXP: " +exp+" puntos EXP";
            }
            esperandoTecla = true;
        }
        else if (other.CompareTag("enemigo"))
        {
            rb.MovePosition(posicionInicial);
            rb.velocity= Vector3.zero;
            rb.angularVelocity= Vector3.zero;
            monedas = 0;
            score.text = "Monedas: 0";
            exp=exp-10;
            XP.text = "EXP:"+exp;
        }
        else if (other.CompareTag("moneda"))
        {
            other.gameObject.SetActive(false);
            monedas = monedas + 1;
            score.text = "Monedas: " + monedas;
            exp = exp +15;
            XP.text = "EXP:" + exp;
        }
        else if(other.CompareTag("Obstaculo"))
        {
            rb.MovePosition(posicionInicial);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }

        else if (other.CompareTag("gema"))
        {
            other.gameObject.SetActive(false);
            gema = gema + 1;
            gemas.text = "Gemas: " + gema;
            exp = exp + 15;
            XP.text = "EXP:" + exp;
        }

        else if (other.CompareTag("escudo"))
        {
            other.gameObject.SetActive(false);
            escudo = escudo + 1;
            escudos.text = "Escudo: " + escudo;
            exp = exp + 15;
            XP.text = "EXP:" + exp;
        }

        else if (other.CompareTag("raresa"))
        {
            other.gameObject.SetActive(false);
            raresa = raresa + 1;
            objetoraro.text = "Rarezas: " + raresa;
            exp = exp + 30;
            XP.text = "EXP:" + exp;
        }

        else if (other.CompareTag("especial"))
        {
            other.gameObject.SetActive(false);
            especial = especial + 1;
            monedasespeciales.text = "Monedas especiales: " + especial;
            exp = exp + 20;
            XP.text = "EXP:" + exp;
        }

        else if (other.CompareTag("Cofrecerrado"))
        {
            Debug.Log("Colisión con cofrecerrado");
            other.gameObject.SetActive(false);
            cofre.SetActive(true);
            gemac.SetActive(true);
            gemacs.SetActive(true);

        }


        else if (other.gameObject.name == "pared")
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.freezeRotation = true;
            rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            rb.rotation = Quaternion.Euler(0f, rb.rotation.eulerAngles.y, 0f);

        }
    }
}
