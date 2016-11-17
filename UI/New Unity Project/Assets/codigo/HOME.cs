using UnityEngine;
using System.Collections;


public class HOME : MonoBehaviour {
	public void ClickClick (){
		Debug.Log ("clicked");
		Application.LoadLevel ("HOME");
	}
	public void ClickTest2 (string text){
		Debug.Log (text);
	}


}





