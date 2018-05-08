using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {


	// Update is called once per frame
	void Update () 
	{
		transform.Translate (new Vector3 (Input.GetAxis ("Horizontal"), 0, 0));
		transform .Translate (new Vector3 (0,Input .GetAxis ("Vertical"),0));
	}
}
