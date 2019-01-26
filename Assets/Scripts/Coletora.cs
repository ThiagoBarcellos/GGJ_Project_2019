using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletora : MonoBehaviour {

    public GameObject abelinha;
    private float vel;
    //-1 esquerda/1 direita
    private int lado = -1;
    private SpriteRenderer sR;

    // Use this for initialization
    void Start () {
        vel = -1.5f;
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        bool flipSprite = (sR.flipX ? (lado > 0.01f) : (lado < 0.01f));
        if (flipSprite)
        {
            sR.flipX = !sR.flipX;
        }

        if (abelinha.transform.localPosition.x > -340)
        {
            abelinha.transform.localPosition += new Vector3(lado * vel, 0, 0);
        }
        if (abelinha.transform.localPosition.x <= -340)
        {
            lado *= -1;
        }
        if(abelinha.transform.localPosition.x < 340)
        {
            abelinha.transform.localPosition += new Vector3(lado * vel, 0, 0);
        }
        if (abelinha.transform.localPosition.x >= 340)
        {
            lado *= -1;
        }
    }
}
