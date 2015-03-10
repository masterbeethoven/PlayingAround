using UnityEngine;
using System.Collections;

public class FlickerScript : MonoBehaviour {
		
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
			
			Debug.Log(this.transform.localScale.x);
			
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


	/*public Vector3 smallSize = new Vector3(160f,30f);
	public Vector3 bigSize = new Vector3(184f,34.5f);
	public int duration = 3; 
	public float startTime;
	public float scaleSize;
	public float speedX = 0F;
	public float speedY = 0F;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float scaleSize = transform.localScale.y;

		if(scaleSize==2){
			this.Shrink();
		}

	}

	void Grow(){

		transform.localScale += new Vector3(speedX, speedY, 0) * Time.deltaTime;

	
	}

	void Shrink(){
		//move = (Time.time - startTime)/ duration; 
		//transform.localScale = Vector3.Slerp(bigSize,smallSize, move);
	}*/

