using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 200f;
	public float sidewaysForce = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if(Input.GetKey("w")){
			rb.AddForce(0,0,forwardForce*Time.deltaTime);
		}else if(Input.GetKey("s")){
			rb.AddForce(0,0,-forwardForce*Time.deltaTime);
		}else if(Input.GetKey("a")){
			rb.AddForce(-sidewaysForce*Time.deltaTime,0,0);
		}else if(Input.GetKey("d")){
			rb.AddForce(sidewaysForce*Time.deltaTime,0,0);
		}
    }
}
