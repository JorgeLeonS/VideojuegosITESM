using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

    // Use this for initialization

    // Update is called once per frame

    public float moveX;
    public Vector3 move;
    public Color color;

    void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            this.ChangeColor();
        }
       
            this.gameObject.transform.Translate(move);
       
        //if (Input.GetKeyDown(KeyCode.LeftArrow)){
           // this.gameObject.transform.Translate(-.1f, 0, 0);
       // }
    }

    Color GetRandomColor()
    {
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);

        return new Color(r, g, b);
    }

    void Start(){
        
    }

    void ChangeColor(){
        gameObject.GetComponent<Renderer>().material.color = this.GetRandomColor();
    }

    void OnMouseDown(){
        this.ChangeColor();
    }
}
