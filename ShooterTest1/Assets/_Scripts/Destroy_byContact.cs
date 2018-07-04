using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_byContact : MonoBehaviour {
	
	public GameObject explosion;
	public GameObject playerExplosion;

	private GameObject boom;
	private GameObject explayer;


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundry") {
			return;
		}
		boom = Instantiate (explosion) as GameObject;
		boom.transform.position = gameObject.transform.position;
		if (other.tag == "Player") {
			explayer = Instantiate (playerExplosion) as GameObject;
			explayer.transform.position = gameObject.transform.position;
		}
		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
