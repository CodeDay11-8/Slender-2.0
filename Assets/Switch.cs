using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	public static int switchesLeft = 4;
	bool fakeswitch;
	int randomNumber;
	Random rand = new Random();

	void setFake(bool isFake)
	{
		fakeswitch = isFake;
	}

	// Use this for initialization
	void Start () {

		randomNumber = Random.Range(0,1);

		switch(randomNumber)
		{
			case 0:
			{
				setFake(false);
				break;
			}
			case 1:
			{
				setFake(true);
				break;
			}
			default:
			{
				setFake(false);
				break;
			}

		}

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

		if (Input.GetMouseButtonDown(0) && this.fakeswitch == false || Input.GetKeyDown(KeyCode.E) && this.fakeswitch == false) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{

				Destroy(GameObject.Find(this.name));
				switchesLeft--;

				if (hit.collider != null)
				{
					hit.collider.enabled = false;
				}

			}
			
			
		}

		else
		{
			//GameObject slenderspawn = (GameObject)Instantiate(slender, new Vector3(0,0,0), transform.rotation);
		}

	}

}
