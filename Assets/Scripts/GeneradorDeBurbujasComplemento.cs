﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeBurbujasComplemento : MonoBehaviour {

	public GameObject burbujaGenerar;
	public float tiempoGeneracion=2f, rangoGeneracion=2f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Creando", 0.0f, tiempoGeneracion);
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	public void Creando(){
		Vector3 SpawnPosition = new Vector3(0,0,0);
		SpawnPosition = this.transform.position + Random.onUnitSphere * rangoGeneracion;
		SpawnPosition = new Vector3(SpawnPosition.y,0);
		GameObject burbuja=Instantiate(burbujaGenerar, SpawnPosition,Quaternion.identity);
	}
}
