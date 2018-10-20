﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirContato : MonoBehaviour {

	public GameObject explosao;

	void OnTriggerEnter(Collider outroCollider) {
		Destroy (outroCollider.gameObject);
		Destroy (this.gameObject);
		Instantiate (explosao, transform.position, transform.rotation);
	}
}
