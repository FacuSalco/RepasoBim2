using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{

    public GameObject brickPrefab;
    public float xOffset;
    public Text userOffset;
    int counter = 0;
    
    void Start()
    {
        xOffset = float.Parse(userOffset.text);
    }

    
    void Update()
    {
        
    }

    public void CloneBrick()
    {
        // Instantiate(brickPrefab); //Spawnea un cubito cada vez que toco el boton

        if (counter == 0)
        {
            xOffset = float.Parse(userOffset.text);
        }

        if (counter < 5) //Spwanean hasta 5
        {
            GameObject clon;
            clon = Instantiate (brickPrefab);
            // Destroy(clon, 2); Se destruye a los 2 segundos
            //clon.transform.position = new Vector3 (-3, 0, 0); //Spawnea 3m para la izquierda
            clon.transform.position = new Vector3 (xOffset, 0, 0); //Spawnea el cubo al lado del anterior a la distancia que sea la variable
            xOffset += 1.1f; //Para tomar como float poner la F al final
            counter++;
        }
    }
}
