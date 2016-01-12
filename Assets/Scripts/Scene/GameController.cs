using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GUIText scoreText;
	private int score;

	void Start()
	{
		score = 0;
		UpdateScore ();
	}

	public void AddScore (int addScoreValue)
	{
		score += addScoreValue;
		UpdateScore();
	}


	void UpdateScore()
	{
		scoreText.text = "" + score;
	}

	void Update()
	{
	
	}
}
