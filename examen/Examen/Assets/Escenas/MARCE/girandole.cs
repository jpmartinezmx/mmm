using UnityEngine;
using System.Collections;

public class girandole : MonoBehaviour {


	public float distancia = 0.5f;

	// Update is called once per frame
	void Update () {

		if (gameObject.name == "Sphere") {
			transform.Rotate (Vector3.up * Time.deltaTime * 50.0f);
		}
	
	}
}
