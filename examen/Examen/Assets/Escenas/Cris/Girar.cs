using UnityEngine;
using System.Collections;

public class Girar : MonoBehaviour {

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.right * Time.deltaTime * 30);
	
	}
}
