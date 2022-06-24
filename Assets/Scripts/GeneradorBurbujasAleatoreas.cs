using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GeneradorBurbujasAleatoreas : MonoBehaviour
{
    public Burbuja[] arregloBurbujas;
    //public GameObject burbuja;
    public Burbuja burbuja;

    private int numeroAleatorio;
    //public int cantidadBurbujas=100;
    // Use this for initialization
    void Start ()
    {
        arregloBurbujas = new Burbuja[100];
        for (int i=0; i<100; i++)
        {
            float posicionX = Random.Range(-5, 5);
            float posicionY = Random.Range(-4, 5);
            float posicionZ = Random.Range(-4, 5);
            Vector3 posicionAleatorea = new Vector3 (posicionX, posicionY, posicionZ);
            //Instantiate (Burbuja, posicionAleatorea, Burbuja.transform.rotation);
            arregloBurbujas[i] =(Instantiate (burbuja, posicionAleatorea, burbuja.transform.rotation));
			
        }


    }
	
    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.A))
        {
			int numeroSorteado=0;
			numeroAleatorio = Random.Range(1,100);
			for (int i = 0; i <= 1; i++) {
				numeroSorteado = numeroAleatorio;
				
			}

			Debug.Log("El número sorteado es: "+numeroSorteado);
			
			arregloBurbujas[numeroSorteado].DestruirBurbuja();
			

        }
        else
        {
            Debug.Log("Cantidad de objetos restantes: "+arregloBurbujas.Count());
        }

        //if (Input.GetKey(KeyCode.S))
        //{
          //  Debug.Log("Cantidad de objetos restantes: "+arregloBurbujas.Count());
        //}

    }
}