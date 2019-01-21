using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	
	void Update () {
		transform.Translate(Vector3.down * 0.2f);
		if (transform.position.y < -5)
		{
			Destroy(this.gameObject);
			Debug.Log("noob");
		}
		if (transform.name.Contains("A") && Input.GetKeyDown("a"))
		{
			if (transform.position.y <= -2.97 + 0.30 && transform.position.y >= -2.97 - 0.30)
				Debug.Log("gg");
			Debug.Log(transform.position.y - -2.97);
			Destroy(this.gameObject);
		}
		if (transform.name.Contains("S") && Input.GetKeyDown("s"))
		{
			if (transform.position.y <= -2.97 + 0.30 && transform.position.y >= -2.97 - 0.30)
				Debug.Log("gg");
			Debug.Log(transform.position.y - -2.97);
			Destroy(this.gameObject);
		}
		if (transform.name.Contains("D") && Input.GetKeyDown("d"))
		{			
			if (transform.position.y <= -2.97 + 0.30 && transform.position.y >= -2.97 - 0.30)
				Debug.Log("gg");
			Debug.Log(transform.position.y - -2.97);
			Destroy(this.gameObject);
		}
	}
}