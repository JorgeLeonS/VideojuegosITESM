using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {


    public bool DoRotation = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(DoRotation){
            transform.Rotate(new Vector3(0.0f, 0.5f, 0.0f));
        }
	}

  
	private void OnMouseDown()
	{
        DoRotation = !DoRotation;
	}

}
