using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

	private float targetTime = 0f;
	public Pipes pipes;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -4f)
			Destroy(this);
		if (Input.GetKeyDown("space") && transform.position.y <= 3.1f)
			targetTime = 0.2f;
		if (targetTime > 0)
		{
			transform.Translate(Vector3.up * 0.1f);
			targetTime -= Time.deltaTime;
		}
		else
			transform.Translate(Vector3.down * 0.1f);
	}
}
