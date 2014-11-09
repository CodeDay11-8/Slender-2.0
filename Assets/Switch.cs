using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	public static int switchesLeft = 4;
	bool fakeswitch = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		/*
		if ( Input.GetMouseButtonDown(0))
		{
			RaycastHit hit = RaycastHit;
			Ray ray = (Ray = Camera.main.ScreenPointToRay (Input.mousePosition));
			
			if (Physics.Raycast (ray, hit, 100.0) && fakeswitch == false)
			{  
				Destroy(GameObject.Find("switch_1"));
				switchesLeft--;
			}
		}
		*/

		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit) && fakeswitch == false)
			{
				
				Destroy(GameObject.Find("switch_1"));
				switchesLeft--;

				if (hit.collider != null)
				{
					hit.collider.enabled = false;
				}

			}
			
			
		}

	}

}
