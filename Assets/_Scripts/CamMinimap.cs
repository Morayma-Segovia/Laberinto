using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMinimap : MonoBehaviour
{
    public Transform Blanco;
    public Transform Morado;
    public Transform Rosa;
    public Transform Celeste;

    private void LateUpdate()
    {
        if(Blanco!=null)
        {
            Vector3 newPosition = Blanco.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
        if (Morado != null)
        {
            Vector3 newPosition = Morado.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
        if (Rosa != null)
        {
            Vector3 newPosition = Rosa.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }
        if (Celeste != null)
        {
            Vector3 newPosition = Celeste.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
        }


    }
}
