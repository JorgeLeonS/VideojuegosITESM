using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    
    public GameObject BulletEmissor;
    
    public GameObject Bullet;
    
	// Use this for initialization
	void Start () {
		InvokeRepeating("Shoot", 0, .5f);
	}
	
	// Update is called once per frame
	void Update () {
		//Shoot();
	}
    
    void Shoot(){
        Instantiate(Bullet, BulletEmissor.transform.position, Quaternion.identity);
    }
    
}
