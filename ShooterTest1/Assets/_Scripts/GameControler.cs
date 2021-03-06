﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWave;
	public float startWait;
	public float waveWait;

	private GameObject obstical;

	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while(true)
		{
			for (int i=0;i<hazardCount;i++) {
				Vector3 spawnPosition = new Vector3 (
					                        Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z
				                        );
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWave);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
