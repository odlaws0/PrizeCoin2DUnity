using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamaras : MonoBehaviour {

	public GameObject camara1;
	public GameObject camara2;
	

	
	void Start ()
	{
		

	}
	
	// Update is called once per frame
	void Update ()
	{
		

	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		camara1.SetActive(false);
		camara2.SetActive(true);
	}
}
