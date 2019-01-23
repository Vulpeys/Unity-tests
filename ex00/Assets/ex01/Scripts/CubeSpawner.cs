using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
	public GameObject a;
	public GameObject s;
	public GameObject d;
	private float targetTime = 0.0f;
	private float RandomSpawnValue;
	private float RandomTimeValueA = 0;
	private float RandomTimeValueS = 0;
	private float RandomTimeValueD = 0;
	private GameObject currentA;
	private GameObject currentS;
	private GameObject currentD;
	void Start () {

	}
	void Update () {
		RandomTimeValueA -= Time.deltaTime;
		RandomTimeValueS -= Time.deltaTime;
		RandomTimeValueD -= Time.deltaTime;
		RandomSpawnValue = Random.Range(0.0f, 3.0f);
		if (RandomTimeValueA <= 0)
			if(RandomSpawnValue <= 1 && !currentA){
					RandomTimeValueA = Random.Range(0.0f, 2.0f);
					currentA = GameObject.Instantiate(a);
			}
		else if (RandomTimeValueS <= 0)
			if (RandomSpawnValue > 1 && RandomSpawnValue <= 2 && !currentS){
				RandomTimeValueS = Random.Range(0.0f, 2.0f);
				currentS = GameObject.Instantiate(s);
			}
		else if (RandomTimeValueD <= 0)
			if (RandomSpawnValue > 2 && !currentD){
				currentD = GameObject.Instantiate(d);
				RandomTimeValueD = Random.Range(0.0f, 2.0f);
		}
	}
}
