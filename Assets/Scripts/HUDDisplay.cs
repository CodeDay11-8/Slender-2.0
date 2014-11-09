using UnityEngine;
using System.Collections;

public class HUDDisplay : MonoBehaviour {

	public static int slendermans = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		guiText.text = "Slendermans: " + slendermans;

	}
}
