using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPanelRayo : MonoBehaviour {
	public float tiempoDeDestruccion=2;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, tiempoDeDestruccion);
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, tiempoDeDestruccion);

	}
}
