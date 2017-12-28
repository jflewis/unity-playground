using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	
	public float sizeModifier = 2.5f;
	public string newName = "Cubey";
	public bool isRotated = false;

	// This is used for initilization
	void Start () {
		if (isRotated) {
			Debug.Log ("is Rotated");
			transform.localEulerAngles = Vector3.one * 45;
		} else {
			Debug.Log ("is not rotated");
		}

		// The transform component
		transform.name = ImproveName(newName);

		//transform.localScale *= sizeModifier;
	}

	// Called once per frame
	void Update () {
		transform.localScale = Vector3.one * sizeModifier;
	}

	string ImproveName (string originalString) {
		return string.Format("-[{0}]-", originalString);
	}
}
