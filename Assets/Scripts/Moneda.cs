using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GirarMoneda();
		
	}
	public void GirarMoneda()
	{
		transform.Rotate(0,8f,0);
	}
}
