using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbuja : MonoBehaviour {

	//public Animator animacion;
	public GameObject boomBurbuja;
	public GameObject cofre;
	public GameObject sonidoBurbuja;
	float contador = 0;
	

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update ()
	{


		contador += Time.deltaTime;
		if (contador >=1)
		{
			GetComponent<CircleCollider2D>().isTrigger = true;
			contador = 0;
		}
		

	}

	public void DestruirBurbuja()
	{
		Destroy(this.gameObject);
		Instantiate(cofre, transform.position, Quaternion.identity);
		Instantiate (sonidoBurbuja, transform.position, Quaternion.identity);
		Instantiate(boomBurbuja, transform.position, Quaternion.identity);
	}


	//public void OnCollisionEnter2D(Collision2D col)
	//{
		//contador += Time.deltaTime;
	//	if(contador>1){
	//	GetComponent<CircleCollider2D>().isTrigger = true;
	//	}
		
	//}


}

