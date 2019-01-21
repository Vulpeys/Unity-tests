using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public int souffle = 5;
	public float targetTime = 1.0f;
	void Start()
	{
		
	}
	void Update()
	{
		targetTime += Time.deltaTime;
		if (Input.GetKeyDown("space")){
			if (souffle <= 15)	{
				transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
				souffle++;
				}
			}
		else{
			if (souffle >= 0){
				if (targetTime >= 1){
					souffle--;
					transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f);
					targetTime = 0;
				}
			}
		}
		if (souffle == 0)
			Destroy(this);
	}
}