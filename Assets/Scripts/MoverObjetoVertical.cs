using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjetoVertical : MonoBehaviour {

	public float velocidad;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 5);

	}

	// Update is called once per frame
	void Update () {
		transform.position+=Vector3.up * velocidad * Time.deltaTime;
		Destroy(gameObject, 5);

	}
}
