using UnityEngine;
using System.Collections;

public class SlideInScript : MonoBehaviour {
	//transform contains vec3, hence .position not needed in Vector3 (you get errors)

	//public Vector3 startPos = new Vector3 (4, 2, -8);
	//public Vector3 endPos = new Vector3(1,2,-8);
	public Transform startPos;
	public Transform endPos;

	//public Transform startPos;
	//public Transform endPos;
	public float speed = 1f;
	private float startTime;
	private float journeyLength;

	 
	void Start() {
		startTime = Time.time;
		//journeyLength = Vector3.Distance(startPos, endPos);
		journeyLength = Vector3.Distance(startPos.position, endPos.position);

	}


	void Update() {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		//transform.position = Vector3.Lerp(startPos, endPos, fracJourney);
		transform.position = Vector3.Lerp(startPos.position, endPos.position, fracJourney);
	}
}
