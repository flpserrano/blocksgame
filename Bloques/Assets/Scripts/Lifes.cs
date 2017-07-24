using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour {

	public static int lifes = 3;
	public Text lifeTxt;

	public BallController ball;

	public BarController bar;

	void Start()
	{
		lifesUpdate();
	}

	public void lifeLost(){
		lifes = lifes -1;
		lifesUpdate();
		bar.Reset();
		ball.Reset();
	}

	void lifesUpdate(){
		lifeTxt.text = "Lifes: "+Lifes.lifes;
	}
}
