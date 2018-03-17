using UnityEngine;
using System.Collections;

public class PuntoDeVista : MonoBehaviour {
    void Update () {
        Vector3 e = transform.rotation.eulerAngles;

        transform.rotation =
            Quaternion.Euler(0, e.y, e.z);
    }
}
