using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PressTest : MonoBehaviour {

	/*public float x= 1f; 
	public float y= 1f; */
	public Vector2 scale = new Vector2(0,0);
	private Vector3 startscale;

	// Use this for initialization
	void Start () {
		startscale = this.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0)){
			//Debug.Log ("button pressed");
		//}
	
	}

	public void OnClick(){
		/*RectTransform button = (RectTransform) transform.GetComponent<RectTransform>();
		RectTransform.sizeDelta = new Vector2( 10, 10);*/

	

		print ("Clicked");
	

		//transform.localScale = new Vector3();
		transform.localScale = new Vector3(scale.x, scale.y);

	
	}

	public void OffClick(){

		print ("Not Clicked");
		transform.localScale = new Vector3(startscale.x, startscale.y);

	}
}
