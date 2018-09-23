using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAI : MonoBehaviour {
    int healthIA = 10;

    void OnGUI()
    {
        GUI.Label(new Rect(1, 25, 100, 20), "IA Health: " + healthIA);
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Translate(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(0, 0, -1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateBomb();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BombPlayer")
        {
            ChangeLifeIA();
            Destroy(other.gameObject);
        }

        if (healthIA == 0)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeLifeIA()
    {
        healthIA = healthIA - 1;
    }

    private GameObject CreateBomb()
    {
        GameObject bombIA = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bombIA.GetComponent<Renderer>().material.color = Color.black;
        bombIA.transform.position = gameObject.transform.position;
        bombIA.AddComponent<Rigidbody>();
        bombIA.GetComponent<Collider>().isTrigger = true;
        bombIA.GetComponent<Rigidbody>().useGravity = false;
        bombIA.transform.localScale = new Vector3(.3f, .3f, .3f);
        bombIA.name = "BombIA";
        return bombIA;
    }
}
