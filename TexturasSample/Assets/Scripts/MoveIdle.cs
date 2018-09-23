using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIdle : MonoBehaviour {
    
    public float speed = 0.5f;
    public int Life = 10;
    
    public Animator AnimatorController;
    public bool dead;
    
	// Use this for initialization
	void Start () {
		
	}
    void OnGUI(){
        GUILayout.Label("Life: " + Life);
    }
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
        transform.Translate(inputX * speed,0,0);
        
        AnimatorController.SetFloat("Speed", Mathf.Abs(inputX));

        if(Life == 0){
            Dead();
        }
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        Life = Life - 1;
    }
    void Dead()

}
