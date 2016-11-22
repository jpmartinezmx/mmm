using UnityEngine;
using System.Collections;

public class alejandra2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.left * Time.deltaTime *200);
	
	}
}
