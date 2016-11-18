using UnityEngine;
using System.Collections;

public class BotonCambio : MonoBehaviour {

	public void cambiarEsena (string nombre) {

		Application.LoadLevel (nombre);

	}
}
