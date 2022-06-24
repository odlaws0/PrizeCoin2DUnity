using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBurbuja : MonoBehaviour {
	public float velocidad=0.3f;
	private float escala=0.4f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		escala = escala + (velocidad * Time.deltaTime);
		transform.localScale = new Vector3 (escala,escala,escala);
		transform.localScale = new Vector3 (escala,escala,escala);

		if (escala>0.6f) {
			escala = 0.6f;
			velocidad = velocidad * -1f;
			
		}
		if (escala < 0.4f) {
			escala = 0.4f;
			velocidad = velocidad * -1f;
		}
	}
}
