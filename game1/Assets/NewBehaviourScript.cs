using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

	public Text ballsText;

	private int count;
	public GameObject wall1;

	public GameObject wall2;

	public Text winText;


	//double check this
	void Start()
	{
		count = 0;
		SetCountText ();
	//	gameObject.tag = "wall1";
		winText.text="";

	}




	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Hazard")) {
			other.gameObject.SetActive (false);

			count = count + 1;
			SetCountText ();
			SetCountText ();



		}
	}

	void SetCountText()
	{
		ballsText.text = "Count:" + count.ToString ();

		if (count >= 21) {



			//DestroyWall ();
			//if(other.gameObject.CompareTag ("wall1")) 
			wall1.SetActive (false);
		}

		if (count >= 23) {
		
			wall2.SetActive (false);
		}

		if (count >= 24) {
			winText.text="You Win!!!";
		
		}
	}


	//	void thisTriggerEnter(Collider other)
		//{
//			if (other.gameObject.CompareTag ("wall1")) {
			//	other.gameObject.SetActive (false);
	//		}
	//	}
	 
}
//void WallDown()
//	{
//		if ( other.gameObject.CompareTag ("wall1")) {
//			other.gameObject.SetActive (false);
//		}
//	}
	//void DestroyWall()
	//{
	//Destroy(gameObject.FindWithTag("wall1"));

	//	other.gameObject.tag = ("wall1");
	//	Destroy(other.gameObject.tag);
//	}


////