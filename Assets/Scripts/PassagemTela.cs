using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassagemTela : MonoBehaviour {

    public GameObject fade;
    private CanvasGroup cg;
    private float inicialAlpha;
    private bool escurecer;

	// Use this for initialization
	void Start () {
        escurecer = false;
        cg = fade.GetComponent<CanvasGroup>();
        inicialAlpha = fade.GetComponent<CanvasGroup>().alpha;
	}

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(passagemDeTela());
    }

    IEnumerator passagemDeTela()
    {
        if (cg.alpha == inicialAlpha && escurecer == false)
        {
            while (cg.alpha != 0)
            {
                yield return new WaitForSeconds(0.1f);
                cg.alpha -= 0.1f;
            }
            escurecer = true;
        }
        yield return new WaitForSeconds(2f);
        if (cg.alpha == 0 && escurecer == true)
        {
            while (cg.alpha != 1)
            {
                yield return new WaitForSeconds(0.05f);
                cg.alpha += 0.1f;
            }
        }
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel("Main");
    }
}
