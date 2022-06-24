using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarCanvasLogin : MonoBehaviour {
	public GameObject canvasLogin;
	public GameObject logo;
	public GameObject cofreAbierto;
	public GameObject iconoAcercaDe;
	// Use this for initialization
	void Start () {
		canvasLogin.SetActive (true);
		logo.SetActive (true);
		cofreAbierto.SetActive (true);
		iconoAcercaDe.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
