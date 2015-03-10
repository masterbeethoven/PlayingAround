using UnityEngine;
using System.Collections;

public class GrowScript : MonoBehaviour {

	//public floats, user created parameters for speed and x and y axis and time 
	public float speedX = 0F;
	public float speedY = 0F;
	public float vectorXSize = 0F;
	public float vectorYSize = 0F;

	// Use this for initialization
	void Start () {


	
	}

	//new method for growing 
	void Grow(){

		//changing the x and y according to user created parameter. Time.deltaTime to make it grow consistently. 
		transform.localScale += new Vector3(speedX, speedY, 0) * Time.deltaTime;
	}

	// Update is called once per frame
	void Update () {

		//transform.localScale += new Vector3(speedX, speedY, 0) * Time.deltaTime;

//		Debug.Log(this.transform.localScale.x);

		//x and y transform 
		float x = this.transform.localScale.x;
		float y = this.transform.localScale.y;

		//grows until the user inputted axis 
		if(x < vectorXSize||y< vectorYSize) 
		{
			Grow();

		}

	}
}
