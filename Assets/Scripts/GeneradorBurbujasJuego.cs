using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBurbujasJuego : MonoBehaviour {

	public float tiempoMax=1;
	private float tiempoInicial = 0;
	public GameObject obstaculo;
	public int cantidadMaximaBurbuja;
	private int cantidadBurbujas=0;
	//public float altura;

	// Use this for initialization
	void Start () {
		GameObject obstaculoNuevo = Instantiate(obstaculo);
		obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);
		cantidadBurbujas++;
	}

	// Update is called once per frame
	void Update () {
		if (cantidadBurbujas < cantidadMaximaBurbuja) {
			if (tiempoInicial > tiempoMax) {
				GameObject obstaculoNuevo = Instantiate (obstaculo);
				obstaculoNuevo.transform.position = transform.position + new Vector3 (0, 0, 0);
				// Destroy(gameObject, 100);
				tiempoInicial = 0;
				cantidadBurbujas++;
			} else {
				tiempoInicial += Time.deltaTime;
			}
		}

	}
}
