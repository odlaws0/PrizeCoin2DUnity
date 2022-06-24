using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorRayosLogin : MonoBehaviour {

	public GameObject rayos;
	public GameObject sonidoRayo;
	public GameObject panelRayo;
	public float tiempoGeneracion=2f, rangoGeneracion=2f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("Creando", 0.0f, tiempoGeneracion);
		Instantiate (sonidoRayo);

	}

	// Update is called once per frame
	void Update () {

	}
	public void Creando(){
		Vector3 SpawnPosition= new Vector3(0,0,0);
		SpawnPosition = this.transform.position + Random.onUnitSphere * rangoGeneracion;
		SpawnPosition = new Vector3(SpawnPosition.y,0);
		GameObject rayoCreado=Instantiate(rayos, SpawnPosition,Quaternion.identity);
		Instantiate (sonidoRayo);
		Instantiate (panelRayo);

	}
}
