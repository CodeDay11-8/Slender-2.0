using UnityEngine;
using System.Collections;

public class SlenderLightScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		

	}
	
	// Update is called once per frame
	void Update () {
		Hashtable data = new Hashtable();
		data.Add( "value", "off" );

		// When you pass a Hashtable as the third argument, we assume you want it send as JSON-encoded
		// data.  We'll encode it to JSON for you and set the Content-Type header to application/json
		HTTP.Request theRequest = new HTTP.Request( "put", "https://graph.api.smartthings.com/api/smartapps/installations/75162506-2436-4206-9b5a-8ef31ba5e5f4/switch", data );
		
		theRequest.AddHeader("Authorization", "Bearer 66686e77-6b73-49a7-8fe7-973c8acd2fee");
		
		
		theRequest.Send( ( request ) => {
			
			// we provide Object and Array convenience methods that attempt to parse the response as JSON
			// if the response cannot be parsed, we will return null
			// note that if you want to send json that isn't either an object ({...}) or an array ([...])
			// that you should use JSON.JsonDecode directly on the response.Text, Object and Array are
			// only provided for convenience
			Hashtable result = request.response.Object;
			if ( result == null )
			{
				Debug.LogWarning( "Could not parse JSON response!" );
				return;
			}
			
		});
	}

}
