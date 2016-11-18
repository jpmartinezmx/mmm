using UnityEngine;
using System.Collections;

public class CambioDePantalla : MonoBehaviour {
	public void CambioDePantallas (string Nombre) 
	{
		Debug.Log ("Me cambié a " + Nombre +"pantalla");
		Application.LoadLevel (Nombre);


	}
}
