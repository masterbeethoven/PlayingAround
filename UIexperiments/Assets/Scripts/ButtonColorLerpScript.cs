using UnityEngine;
using System.Collections;

public class ButtonColorLerpScript : MonoBehaviour {

	public Color lerpedColor;
	public Color startColor;
	public Color endColor;
	public float lerpSpeed; 
	public float lerpLoop;
	//public Color actualColor;
	//public Color startColor =new Color(1,1,1,1);//white 
	//public Color endColor=new Color(1, 0, 1, 1); //magenta


	// Use this for initialization
	void Start () {


		//lerpedColor = Color.red;

		//this.gameObject.renderer.material.color = lerpedColor;
	}
	
	// Update is called once per frame
	void Update () {

		//actualColor = Color.Lerp(startColor, endColor, colorLerp);
		lerpedColor = Color.Lerp(startColor, endColor, Time.time)*lerpSpeed;

		if (lerpedColor==endColor){
			lerpedColor = Color.Lerp(startColor, endColor, Time.time)*lerpSpeed;
				
		}

		
		//actualColor=lerpedColor;
	
		this.gameObject.renderer.material.color = lerpedColor;
	}
}


