using UnityEngine;
using System.Collections;

public class SeguimientoCamara : MonoBehaviour {
    public GameObject target;
    
    void Update () {
        transform.position = target.transform.position;
    }
}
