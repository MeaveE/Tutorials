using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_byBoundry : MonoBehaviour {

		void OnTriggerExit(Collider other)
		{
			// Destroy everything that leaves the trigger
			Object.DestroyObject(other.gameObject);
		}
		

}
