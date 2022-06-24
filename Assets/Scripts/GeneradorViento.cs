using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorViento : MonoBehaviour {

	// Use this for initialization
	public float tiempoMax=1;
	private float tiempoInicial = 0;
	public GameObject obstaculo;
	//public GameObject sonidoViento;
	//public float altura;

	// Use this for initialization
	void Start () {
		GameObject obstaculoNuevo = Instantiate(obstaculo);
		obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
		//Instantiate (sonidoViento);
	}

	// Update is called once per frame
	void Update () {

		if (tiempoInicial > tiempoMax)
		{
			GameObject obstaculoNuevo = Instantiate(obstaculo);
			obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
			//Instantiate (sonidoViento);
			tiempoInicial = 0;
		}
		else {
			tiempoInicial += Time.deltaTime;
		}

	}
}
