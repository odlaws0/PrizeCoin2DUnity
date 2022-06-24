using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBurbujaComplemento : MonoBehaviour {

	public float velocidad=0.1f;
	private float escala=0.25f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		escala = escala + (velocidad * Time.deltaTime);
		transform.localScale = new Vector3 (escala,escala,escala);
		transform.localScale = new Vector3 (escala,escala,escala);

		if (escala>0.35f) {
			escala = 0.35f;
			velocidad = velocidad * -1f;

		}
		if (escala < 0.25f) {
			escala = 0.25f;
			velocidad = velocidad * -1f;
		}
	}
}
