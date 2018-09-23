using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesPlayerLife
{
	public class GameMaster : MonoBehaviour {

        public Sphere Sphere;
		// Use this for initialization
        void OnMouseDown()
        {
            Sphere.BajaVida();
        }
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
	}
}
