using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject original;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.right * Time.deltaTime);
		Instantiate (original, transform.position, Quaternion.identity);
	}
}
