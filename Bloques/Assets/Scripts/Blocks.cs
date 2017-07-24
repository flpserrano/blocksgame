using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {

	public GameObject particles;
	void OnCollisionEnter(Collision other)
	{
		Instantiate(particles,transform.position,Quaternion.identity);
		Destroy(gameObject);	
	}
}
