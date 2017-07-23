using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public Rigidbody rig;
	public float initialVelocity = 600f;
	bool onPlay = false;
	Vector3 initialPosition;
	public Transform bar;

	void Awake()
	{
		initialPosition = transform.position;
	}
	void Update()
	{
		if(!onPlay && Input.GetButtonDown("Fire1"))
		{
			onPlay = true;
			transform.SetParent(null);
			rig.isKinematic = false;
			rig.AddForce(new Vector3(initialVelocity,initialVelocity,0));
		}
	}

	public void Reset()
	{
		transform.position = initialPosition;
		transform.SetParent(bar);
		onPlay = false;
		stopMovement();
	}

	public void stopMovement()
	{
		rig.isKinematic = true;
		rig.velocity = Vector3.zero;
	}
}
