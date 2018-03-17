using UnityEngine;
using System.Collections;

public class ControlPersonaje : MonoBehaviour {
    public float speed = 5;
    public GameObject puntoDeVista;

    void Update () {
        Vector3 deltaMovement = 
            (puntoDeVista.transform.forward *
             Input.GetAxis("Vertical") +
             
             puntoDeVista.transform.right *
             Input.GetAxis("Horizontal")).normalized
            * Time.deltaTime * speed *

            Mathf.Max(Mathf.Abs(Input.GetAxis("Vertical")),
                      Mathf.Abs(Input.GetAxis("Horizontal")));

        transform.position += deltaMovement;

        if (deltaMovement.magnitude != 0) {
            transform.forward = deltaMovement;
        }
    }
}
