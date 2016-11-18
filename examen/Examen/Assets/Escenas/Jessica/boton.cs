using UnityEngine;
using System.Collections;

public class boton : MonoBehaviour {

	public void CambiarEscena (string nombre) {
		Application.LoadLevel (nombre);
}
}