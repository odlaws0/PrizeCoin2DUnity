using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
	[SerializeField] private float velocidad = 0, final = 0, inicio = 0, inverso = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate((Vector2.left * velocidad * Time.deltaTime) * inverso);
		if (transform.position.x <= final)
		{
			Vector2 startPosition = new Vector2(inicio, transform.position.y);
			transform.position = startPosition;
		}
	}
}
