using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class selfDestroy : MonoBehaviour {

    public GameObject pai;
    public Text melProcriacaoBG1, melProcriacaoBG2, melProcriacaoBG4;


    public void OnMouseDown()
    {
            Debug.Log("pora");
            spawn.abelha += 1;
            Destroy(pai);
    }
    public void updateTexto()
    {
        melProcriacaoBG1.text = spawn.abelha.ToString();
        melProcriacaoBG2.text = spawn.abelha.ToString();
        melProcriacaoBG4.text = spawn.abelha.ToString();
    }
}