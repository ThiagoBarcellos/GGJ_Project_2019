using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class spawn : MonoBehaviour {

    public GameObject larvinhas, abelhaObject, bgfavo;
    public float heightMax, heightMin, widthMax, widthMin, positionSpawnX, positionSpawnY;
    public Text melPolinizacaoBG1, melPolinizacaoBG2, melPolinizacaoBG4, melProcriacaoBG1, melProcriacaoBG2, melProcriacaoBG4;
    public static int abelha = 1;
    public int custoAbelha, polem;


    // Use this for initialization
    void Start () {
        melProcriacaoBG1.text = abelha.ToString();
        melProcriacaoBG2.text = abelha.ToString();
        melProcriacaoBG4.text = abelha.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        polem = ColetaPolem.polem;
    }

    public void OnClick()
    {
       
        if (polem >= custoAbelha)
        {
            polem -= custoAbelha;
            custoAbelha += 10;
            positionSpawnX = Random.Range(widthMin, widthMax);
            positionSpawnY = Random.Range(heightMin, heightMax);
            Instantiate(larvinhas, new Vector3(positionSpawnX, positionSpawnY, -1), Quaternion.identity);
            //larvinhas.transform.SetParent(bgfavo.transform);
            StartCoroutine(spawnAbelhas());
        }

        melPolinizacaoBG1.text = polem.ToString();
        melPolinizacaoBG2.text = polem.ToString();
        melPolinizacaoBG4.text = polem.ToString();

    }

    IEnumerator spawnAbelhas()
    {
        yield return new WaitForSeconds(2f);
        transformarAbelha();
        yield break;
    }

    public void transformarAbelha()
    {
        updateTexto();
    }

    public void updateTexto()
    {
        melProcriacaoBG1.text = abelha.ToString();
        melProcriacaoBG2.text = abelha.ToString();
        melProcriacaoBG4.text = abelha.ToString();
    }
}
