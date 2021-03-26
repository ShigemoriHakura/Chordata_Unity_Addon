using UnityEngine;
using System.Collections;

public class ReceivePosition : MonoBehaviour {
    
   	public OSC osc;


	// Use this for initialization
	void Start () {
	   osc.SetAddressHandler("/%/kc-CH_4-2", OnReceiveXYZ );
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnReceiveXYZ(OscMessage message){
        Debug.Log(message.ToString());
        float w = message.GetFloat(0);
        float x = message.GetFloat(1);
		float y = message.GetFloat(2);
        float z = message.GetFloat(3);

        transform.localRotation = new Quaternion(x, -z, y, w);
	}

}
