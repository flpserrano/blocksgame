using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour {

	public float velocity = 20f;
	Vector3 initialPosition;
	
	void Start () {
		initialPosition = transform.position;
	}

	void Update () {
		float horizontalKeyboard = Input.GetAxisRaw	("Horizontal");
		float posX = transform.position.x + (horizontalKeyboard * velocity * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX,-8,+8), transform.position.y, transform.position.z);
	}

	public void Reset()
	{
		transform.position = initialPosition;
	}
}
