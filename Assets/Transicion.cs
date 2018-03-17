using UnityEngine;
using System.Collections;

public class Transicion : MonoBehaviour {
    public GameObject posicionDeSprint;
    public float tiempoDeTransicion = 1;

    private GameObject _posRotOriginal;

    void Start () {
        _posRotOriginal = new GameObject();
        _posRotOriginal.transform.parent = transform.parent;
        _posRotOriginal.transform.position = transform.position;
        _posRotOriginal.transform.rotation = transform.rotation;
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            StopAllCoroutines();
            StartCoroutine(Transicionar(posicionDeSprint));
        } else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            StopAllCoroutines();
            StartCoroutine(Transicionar(_posRotOriginal));
        }
    }

    IEnumerator Transicionar (GameObject objetivo) {
        float tiempoTranscurrido = 0;
        Vector3 original = transform.position;
        Quaternion rotOriginal = transform.rotation;

        while (tiempoTranscurrido < tiempoDeTransicion) {
            transform.position = Vector3.Lerp(original, objetivo.transform.position,
                                              tiempoTranscurrido / tiempoDeTransicion);

            transform.rotation = Quaternion.Lerp(rotOriginal, objetivo.transform.rotation,
                                                 tiempoTranscurrido / tiempoDeTransicion);
            tiempoTranscurrido += Time.deltaTime;
            yield return null;
        }
    }
}
