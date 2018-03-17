using UnityEngine;
using System.Collections;

public class SphericalMovement : MonoBehaviour {
    public float angularSpeed = 5; // en radianes
    public float radius = 2;

    public Vector3 center;
    private float _angle;

    void Start () {
        center = transform.position + new Vector3(0,0, radius);
    }

    void Update () {
        _angle += angularSpeed * Time.deltaTime;

        transform.position = center +
            new Vector3(Mathf.Sin(_angle), 0, Mathf.Cos(_angle)) * radius;
    }
}
