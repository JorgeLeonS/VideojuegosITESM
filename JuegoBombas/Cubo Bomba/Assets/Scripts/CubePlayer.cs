using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlayer : MonoBehaviour {
    int healthPlayer = 10;
    public Texture text;
    //Vector3Int BombaInicial = gameObject.transform.position;

    void OnGUI()
    {
        GUI.Label(new Rect(1, 5, 100, 20), "Player Health: " + healthPlayer);
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.Translate(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.Translate(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.Translate(0, 0, -1);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.Translate(0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateBomb();
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "BombIA")
        {
            ChangeLifePlayer();
            Destroy(other.gameObject);
        }

        if (healthPlayer == 0)
        {
            Destroy(gameObject);
        }
    }

    public void ChangeLifePlayer()
    {
        healthPlayer = healthPlayer - 1;
    }

    private GameObject CreateBomb()
    {
        GameObject bombPlayer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bombPlayer.GetComponent<Renderer>().material.color = Color.white;
        bombPlayer.transform.position = gameObject.transform.position;
        bombPlayer.AddComponent<Rigidbody>();
        bombPlayer.GetComponent<Collider>().isTrigger = true;
        bombPlayer.GetComponent<Rigidbody>().useGravity = false;
        bombPlayer.transform.localScale = new Vector3(.3f, .3f, .3f);
        bombPlayer.name = "BombPlayer";
        return bombPlayer;
    }
}
