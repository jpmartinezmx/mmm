using UnityEngine;
using System.Collections;

public class Jose : MonoBehaviour {

	// Use this for initialization

	public void CambiarEscena (string nombre)  {
		Application.LoadLevel (nombre);
	}


}
