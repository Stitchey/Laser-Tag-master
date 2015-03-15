using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	private float xRotation = 0.0f;
	private float yRotation = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		xRotation += Input.GetAxis ("Mouse X") * GameManager.xSensitivity;
		yRotation -= Input.GetAxis ("Mouse Y") * GameManager.ySensitivity;

		transform.localEulerAngles = new Vector3 (yRotation, xRotation, 0);
	
	}
}
