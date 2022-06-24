using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminosCondiciones : MonoBehaviour {
	public GameObject canvasLogin;
	public GameObject canvasTerminosCondiciones;

	public GameObject cofreAbierto;
		public GameObject iconoAcercaDe;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void oprimirTerminosCondiciones(){
		canvasLogin.SetActive (false);

		cofreAbierto.SetActive (false);
		iconoAcercaDe.SetActive (false);
		canvasTerminosCondiciones.SetActive (true);

	}
	public void oprimirBotonoAtras(){
		canvasLogin.SetActive (true);

		cofreAbierto.SetActive (true);
		iconoAcercaDe.SetActive (true);
		canvasTerminosCondiciones.SetActive (false);		

	}
}
