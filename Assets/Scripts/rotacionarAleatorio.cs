using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionarAleatorio : MonoBehaviour {

	private Rigidbody componenteRb;
	public int forca = 50;
	void Start () {
		componenteRb = GetComponent<Rigidbody> ();
		componenteRb.AddTorque (Random.insideUnitCircle * forca);
	}
		
}
