using UnityEngine;
using System.Collections;

public class CursorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if ( Input.GetKeyDown (KeyCode.H) )
			{
			Screen.showCursor = !Screen.showCursor;
			}
	}
}
