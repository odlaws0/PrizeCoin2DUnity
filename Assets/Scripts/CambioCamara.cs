using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour {
	public GameObject[] listaCamaras;
	int numeroCamaras=3;
	// Use this for initialization
	void Start () {

		for(int i=0; i<numeroCamaras; i++)
		{
			listaCamaras [i].gameObject.SetActive (false);
		}
		listaCamaras [0].gameObject.SetActive (true);

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Alpha1)) {
			apagarCamaras ();
			listaCamaras [0].gameObject.SetActive (true);
			Debug.Log ("Cámara 1");
		}
		if (Input.GetKey (KeyCode.Alpha2)) {
			apagarCamaras ();
			listaCamaras [1].gameObject.SetActive (true);
			Debug.Log ("Cámara 2");
		}
		if (Input.GetKey (KeyCode.Alpha3)) {
			apagarCamaras ();
			listaCamaras [2].gameObject.SetActive (true);
			Debug.Log ("Cámara 3");
		}

	}

	void apagarCamaras()
	{
		for(int i=0; i<numeroCamaras; i++)
		{
			listaCamaras [i].gameObject.SetActive (false);
		}

	}
}