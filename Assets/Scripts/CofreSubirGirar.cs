using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreSubirGirar : MonoBehaviour {
	private float contador=1;

	// Use this for initialization
	void Start () {
		

		
	}

	// Update is called once per frame
	void Update () {
		contador+=2;
		if (contador < 140) {
			transform.Rotate (0, 10f, 0);

		}

	}
}
