using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    // Start is called before the first frame update
	public Vector3 offset;
	public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
		transform.position = player.position;
        transform.rotation = player.rotation;

    }


}
