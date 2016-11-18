using UnityEngine;
using System.Collections;

public class UImanage : MonoBehaviour {

	public void cambiarEsena (string nombre) {

		Application.LoadLevel (nombre);

	}
}
