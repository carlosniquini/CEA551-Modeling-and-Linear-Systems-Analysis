using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour {

	public GameObject plataforma;
	public GameObject plataforma_saida;

	private int[,] cenario = new int[,]
	{
		{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
		{0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
		{0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
		{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
	};

	// Use this for initialization
	void Start () {
		gerarCenario ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void gerarCenario(){
		for (int i = 0; i < cenario.GetLength (0); i++) {
			for (int j = 0; j < cenario.GetLength (1); j++) {
				GameObject tmp = (cenario [i, j] == 1) ? plataforma_saida : plataforma;
				Instantiate (tmp, new Vector3 ((i*2f), 0, (j*2f)), tmp.transform.rotation);
				//Debug.Log (cenario [i, j]);
			}
		}
	}
}
