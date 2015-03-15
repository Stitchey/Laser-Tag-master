using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public static float xSensitivity = 5.0f;
	public static float ySensitivity = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void Awake () 
	{
		// Make sure there's only one instance of this class
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}
}
