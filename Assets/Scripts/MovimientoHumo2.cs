using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHumo2 : MonoBehaviour {
	private float contador=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		contador++;
		if (contador < 70) {
			transform.Rotate (0, 8f, 0);
		}

		else {
			transform.position = new Vector3 (30, 0, 0);
		}
		
	}
}
