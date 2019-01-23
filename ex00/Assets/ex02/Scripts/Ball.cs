using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Club club;
	public bool travel = false;
	// Use this for initialization	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (club.hit == true)
		{
			travel = true;
			transform.Translate(Vector3.up * 0.2f);
			if (club.distance > 0)
				club.distance -= 0.2f;
			if (club.distance < 0)
				club.distance += 0.2f;
			if (club.distance <= 0.1f && club.distance >= -0.1f)
			{
				club.hit = false;
				travel = false;	
				if(club.transform.position.y < transform.position.y)
					club.transform.position = new Vector3(0, transform.position.y - 0.5f, -2);
				if(club.transform.position.y > transform.position.y)
					club.transform.position = new Vector3(0, transform.position.y + 0.5f, -2);
			}
			if (transform.position.y >= 6f)
				transform.rotation = Quaternion.Euler(190, 0, 0);
			else if (transform.position.y <= -6f)
 				transform.rotation = Quaternion.Euler(0, 0, 0);

		}
		if (travel == false && transform.position.y >= 3.5f && transform.position.y <= 4.5f)
			Destroy(this.gameObject);
	}
}
