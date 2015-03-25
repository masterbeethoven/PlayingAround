using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonImageChange : MonoBehaviour {

	public Sprite earthPNG;
	public Sprite checkMark;
	public Panel panelOverlay;



	//SpriteRenderer spriteRenderer;
	
	
	bool paused = false;
	
	void Update()
	{

	}
	
	void OnClick()
	{
		Image img = GetComponent<Image>(); 

		//if(Input.GetButtonDown("pauseButton"))
			paused = togglePause();

		if (paused){
			img.sprite = earthPNG;
		}
		else {
			img.sprite = checkMark;


		}
	}
	
	bool togglePause()
	{
		//Resources.Load <Sprite> ("checkMark.jpg");

		return !paused;


	}
}
