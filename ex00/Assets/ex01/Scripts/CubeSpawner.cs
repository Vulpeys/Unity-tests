using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject a;
	public GameObject s;
	public GameObject d;
	private float targetTime = 0.0f;
	private float RandomSpawnValue;
	private float RandomTimeValue = 0;
	private GameObject currentA;
	private GameObject currentS;
	private GameObject currentD;
	void Start () {	
	}
	void Update () {
		targetTime += Time.deltaTime;
		RandomTimeValue -= Time.deltaTime;
		if (targetTime >= 1)
		{
			RandomSpawnValue = Random.Range(0.0f, 3.0f);
			if (RandomTimeValue <= 0){
				if(RandomSpawnValue <= 1 && !currentA)
						currentA = GameObject.Instantiate(a);
				else if (RandomSpawnValue > 1 && RandomSpawnValue <= 2 && !currentS)
						currentS = GameObject.Instantiate(s);
				else if (RandomSpawnValue > 2 && !currentD)
						currentD = GameObject.Instantiate(d);
				RandomTimeValue = Random.Range(0.0f, 2.0f);
			}
			targetTime = 0.0f;
		}
	}
}
