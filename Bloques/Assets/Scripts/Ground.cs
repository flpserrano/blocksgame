using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	public Lifes lifes;
	void OnTriggerEnter(Collider other)
	{
		lifes.lifeLost();
	}
}
