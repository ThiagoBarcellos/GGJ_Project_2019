using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ColetaPolem : MonoBehaviour {

    public Text melPolinizacaoBG1, melPolinizacaoBG2, melPolinizacaoBG4;
    public static int polem;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void onClick() {
        polem = SceneManager.polem +=1;
        melPolinizacaoBG1.text = polem.ToString();
        melPolinizacaoBG2.text = polem.ToString();
        melPolinizacaoBG4.text = polem.ToString();

    }
}
