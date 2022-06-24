using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObstaculos : MonoBehaviour {
	public float tiempoMax=1;
	private float tiempoInicial = 0;
	public GameObject obstaculo;
	//public float altura;

	// Use this for initialization
	void Start () {
		GameObject obstaculoNuevo = Instantiate(obstaculo);
		obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
		//Destroy(gameObject, 100);
	}

	// Update is called once per frame
	void Update () {

		if (tiempoInicial > tiempoMax)
		{
			GameObject obstaculoNuevo = Instantiate(obstaculo);
			obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
			// Destroy(gameObject, 100);
			tiempoInicial = 0;
		}
		else {
			tiempoInicial += Time.deltaTime;
		}

	}
}
