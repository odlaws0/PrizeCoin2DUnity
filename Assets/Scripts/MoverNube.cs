using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverNube : MonoBehaviour {

	// Use this for initialization
	public float velocidad;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 20);

	}

	// Update is called once per frame
	void Update () {
		transform.position+=Vector3.right * velocidad * Time.deltaTime;
		Destroy(gameObject, 20);

	}
}
