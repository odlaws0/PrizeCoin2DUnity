using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcercaDe : MonoBehaviour {

	public GameObject canvasLogin;
	public GameObject canvasAcercaDe;
	public GameObject acercaDe;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void oprimirAcercaDe(){
		canvasLogin.SetActive (false);
		acercaDe.SetActive (false);
		canvasAcercaDe.SetActive (true);

	}
	public void oprimirBotonoAtrasAcercaDe(){
		canvasLogin.SetActive (true);
		acercaDe.SetActive (true);
		canvasAcercaDe.SetActive (false);		
	}
}
