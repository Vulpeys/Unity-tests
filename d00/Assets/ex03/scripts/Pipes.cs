using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour {
	public bird bird;
	private float tmpScore = 0f;
	private int finalScore = 0;
	public float speed = 0.1f;
	private float randomPositiom = 0f;
	private float playedTime = 0.1f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (bird){
			playedTime += Time.deltaTime;
			if (bird.transform.position.y >= transform.position.y + 1.27 && ((transform.position.x -1.26f) <= (bird.transform.position.x)) &&((transform.position.x +1.26f) >= (bird.transform.position.x + 0.2)))
			{
				Debug.Log(finalScore);
				Debug.Log(playedTime);
				Destroy(bird);
			}
			if (bird.transform.position.y <= transform.position.y - 1.69 && ((transform.position.x +1.26f) >= (bird.transform.position.x)) &&((transform.position.x -1.26f) <= (bird.transform.position.x - 0.2)))
			{
				Debug.Log(finalScore);
				Debug.Log(playedTime);
				Destroy(bird);
			}
			transform.Translate(Vector3.left * speed);
			if (transform.position.x <= -5.50f)
			{
				finalScore += 5;
				tmpScore += 1f;
				randomPositiom = Random.Range(-2.0f, 3.0f);
				transform.position = new Vector3(5.50f,randomPositiom ,0);
			}
			if (tmpScore == 5)
			{
				speed += 0.03f;
				tmpScore = 0f;
			}
		}
	}
}