using UnityEngine;
using System.Collections;

public class girar : MonoBehaviour {

	public float distancia = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.name == "circulo1") {
			transform.Rotate (Vector3.down * Time.deltaTime * 30.0f);
		}

		if (gameObject.name == "circulo2") {
			transform.Rotate (Vector3.up * Time.deltaTime * 100.0f);
		}

		if (gameObject.name == "circulo3") {
			transform.Rotate (Vector3.down * Time.deltaTime * 70.0f);
		}

		if (gameObject.name == "circulo4") {
			transform.Rotate (Vector3.down * Time.deltaTime * 60.0f);
		}

		if (gameObject.name == "circulo5") {
			transform.Rotate (Vector3.up * Time.deltaTime * 50.0f);
		}

		if (gameObject.name == "circulo6") {
			transform.Rotate (Vector3.down * Time.deltaTime * 20.0f);
		}

		if (gameObject.name == "circulo7") {
			transform.Rotate (Vector3.up * Time.deltaTime * 100.0f);
		}

		if (gameObject.name == "circulo8") {
			transform.Rotate (Vector3.down * Time.deltaTime * 10.0f);
		}

		if (gameObject.name == "circulo9") {
			transform.Rotate (Vector3.up * Time.deltaTime * 5.0f);
		}

		if (gameObject.name == "circulo10") {
			transform.Rotate (Vector3.down * Time.deltaTime * 10.0f);
		}
	}



}
