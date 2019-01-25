using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {
	public Ball ball;
	public bool hit = false;
	public float distance = 0;
	void Start () {
		
	}
	
	void Update () {
		if (ball.travel != true && ball)
		{
			if (transform.position.y < 4)
				transform.rotation = Quaternion.Euler(0, 0, 0);
			else
				transform.rotation = Quaternion.Euler(190, 0, 0);
			if (Input.GetKey("space"))
				transform.Translate(Vector3.down * 0.1f);
			if (Input.GetKeyUp("space"))
			{
				if (transform.position.y < 4)
					{
						distance = transform.position.y - ball.transform.position.y;
						transform.position = new Vector3(0, ball.transform.position.y - 0.5f, -2);
					}
				else
				{
					distance = transform.position.y - ball.transform.position.y;
					transform.position = new Vector3(0, ball.transform.position.y + 0.5f, -2);
				}
				ball.transform.rotation = transform.rotation;
				hit = true;
			}
		}
	}
}
