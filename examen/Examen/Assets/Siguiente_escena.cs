using UnityEngine;
using System.Collections;

public class Siguiente_escena : MonoBehaviour {
	public void cambiarEscena (string nombre) {

		Application.LoadLevel (nombre);

	}

}