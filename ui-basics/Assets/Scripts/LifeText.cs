using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeText : MonoBehaviour {


    public Text Life;

    public int LifeNum = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate(){
        UpdateUI();
    }

    void UpdateUI(){
        Life.text = "" + LifeNum;
    }
}
