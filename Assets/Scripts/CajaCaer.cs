using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCaer : MonoBehaviour {


	public GameObject cajaFragmentos;
	public GameObject sonido;
	public GameObject moneda;
	public GameObject canvasYouWin;
	public GameObject sonidoGolpe;
	public GameObject humo1;
	public GameObject humo2;
	public GameObject boom;


	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnCollisionEnter2D (Collision2D collision)
	{
		//throw new NotImplementedException();
		if (collision.gameObject.name == "Piso")
		{
			
			Instantiate (sonidoGolpe);
			Instantiate(sonido);
			Instantiate(cajaFragmentos, transform.position + new Vector3(0,7,0), Quaternion.identity);
			Instantiate (moneda,transform.position + new Vector3(0,8,0) , Quaternion.identity);
			//moneda.transform.position = new Vector3(Quaternion.identity);
			Instantiate (humo1,transform.position+ new Vector3(0.2f,0,0) ,Quaternion.identity);
			//humo1.transform.position = new Vector3 (1.6f, -3.4f, 0);
			Instantiate (humo2,transform.position + new Vector3(-0.2f,0,0),Quaternion.identity);
			//humo2.transform.position = new Vector3 (-0.9f, -0.90f, 0);
			Instantiate (boom,transform.position,Quaternion.identity);
			//boom.transform.position = new Vector3 (0, -6f, 0);
			//boom.SetActive (true);
			Instantiate (canvasYouWin);
			Destroy(this.gameObject);
		}
	}
}
