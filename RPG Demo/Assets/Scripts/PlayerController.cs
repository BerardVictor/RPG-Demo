using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	void Start() 
	{
		
	}

	void Update()
	{
		transform.Rotate(0,Input.GetAxis("Rotate")*60*Time.deltaTime,0);
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
	    Vector3 position = transform.position;
	    position.x = position.x + 0.1f * horizontal;
	    position.z = position.z + 0.1f * vertical;
	    transform.position = position;
	}
}
