using UnityEngine;
using System.Collections;

public class cambalache : MonoBehaviour {

	public void CambioDePantallas (string Nombre) 
	{
		Debug.Log ("hola" + Nombre);
		Application.LoadLevel (Nombre);


	}

}
