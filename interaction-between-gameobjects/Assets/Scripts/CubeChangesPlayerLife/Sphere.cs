using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
    public int puntosDeVida = 10;
    public Texture texto;

	void OnGUI()
	{
        GUILayout.Label(texto);
        GUILayout.Label("Quedan " + puntosDeVida + " puntos de vida;");
	}

    public void BajaVida(){
        puntosDeVida = puntosDeVida - 1;
    }

	


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
