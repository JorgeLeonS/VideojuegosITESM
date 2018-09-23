using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewShroom : MonoBehaviour {

    public GameObject Spawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            DoSpawn();
        }
	}

    public void DoSpawn(){
        GameObject go = Instantiate(Spawn, transform.position, Quaternion.identity);
        go.AddComponent<Rigidbody>();
        go.AddComponent<BoxCollider>();
    }


}
