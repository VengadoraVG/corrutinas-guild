using UnityEngine;
using System.Collections;

public class Corrutina : MonoBehaviour {
    public Coroutine a;
    public Coroutine s;
    public Coroutine d;

    void Start () {
        StartCoroutine( EsperarCorrutina() );
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) ||
            Input.GetKeyDown(KeyCode.D)) {
            StopAllCoroutines();
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            StopCoroutine(a);
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            a = StartCoroutine(Mover());
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            s = StartCoroutine(MoverPorFrame());
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            d = StartCoroutine(EsperarCorrutina());
        }
    }

    public IEnumerator Mover () {
        for (int i=0; i<10; i++) {
            transform.position += new Vector3(0,0, 1);
            yield return new WaitForSeconds(0.2f);
        }
    }

    public IEnumerator MoverPorFrame () {
        for (int i=0; i<50; i++) {
            transform.position += new Vector3(0,0, 5) * Time.deltaTime;
            yield return null;
        }
    }

    public IEnumerator EsperarCorrutina () {
        yield return StartCoroutine(Mover());
        yield return StartCoroutine(MoverPorFrame());
    }
}
