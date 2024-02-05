using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMARA : MonoBehaviour
{
    public GameObject Rosa;
    public GameObject Celeste;
    public GameObject Blanco;
    public GameObject Morado;
    public GameObject referencia;
    private Vector3 distancia;

    // Start is called before the first frame update

    void Start()
    {
        if (Rosa != null)
        {
            distancia = transform.position - Rosa.transform.position;
        }
        if (Blanco != null)
        {
            distancia = transform.position - Blanco.transform.position;
        }
        if (Celeste != null)
        {
            distancia = transform.position - Celeste.transform.position;
        }
        if (Morado != null)
        {
            distancia = transform.position - Morado.transform.position;
        }
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Rosa != null)
        {
            distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
            transform.position = Rosa.transform.position + distancia;
            transform.LookAt(Rosa.transform.position);
            Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
            referencia.transform.eulerAngles = copiaRotacion;
        }
        if (Blanco != null)
        {
            distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
            transform.position = Blanco.transform.position + distancia;
            transform.LookAt(Blanco.transform.position);
            Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
            referencia.transform.eulerAngles = copiaRotacion;
        }
        if (Celeste != null)
        {
            distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
            transform.position = Celeste.transform.position + distancia;
            transform.LookAt(Celeste.transform.position);
            Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
            referencia.transform.eulerAngles = copiaRotacion;
        }
        if (Morado != null)
        {
            distancia = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distancia;
            transform.position = Morado.transform.position + distancia;
            transform.LookAt(Morado.transform.position);
            Vector3 copiaRotacion = new Vector3(0, transform.eulerAngles.y, 0);
            referencia.transform.eulerAngles = copiaRotacion;
        }
        
    }
}
