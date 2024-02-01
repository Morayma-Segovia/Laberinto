using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_move : MonoBehaviour
{
    public Rigidbody rb;
    public Text score;
    public Text tvictoria;
    bool haSalido;
    //public float forwardForce = 2000;
    public float sideForce = 200;
    Vector3 posicionInicial;
    int monedas = 0;
    public 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posicionInicial= transform.position;
        tvictoria.enabled = false;
        haSalido = false;

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

        }
        else if (other.CompareTag("enemigo"))
        {
            rb.MovePosition(posicionInicial);
            rb.velocity= Vector3.zero;
            rb.angularVelocity= Vector3.zero;
            monedas = 0;
            score.text = "Monedas Recolectadas: 0";
        }
        else if (other.CompareTag("moneda"))
        {
            other.gameObject.SetActive(false);
            monedas = monedas + 1;
            score.text = "Monedas Recolectadas: " + monedas;
        }
        else if(other.CompareTag("Obstaculo"))
        {
            rb.MovePosition(posicionInicial);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
