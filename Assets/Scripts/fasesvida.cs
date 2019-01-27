using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fasesvida : MonoBehaviour {

    private GameObject larvinha, operaria;

	// Use this for initialization
	void Start () {
        larvinha = this.transform.Find("larvinha").gameObject;
        operaria = this.transform.Find("Operaria").gameObject;
        
        operaria.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
        StartCoroutine(TempoDeEspera());
	}

    IEnumerator TempoDeEspera() {
        yield return new WaitForSeconds(2f);
        larvinha.SetActive(false);
        operaria.SetActive(true);
    }
}
