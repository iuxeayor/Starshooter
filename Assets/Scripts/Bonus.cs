//Bonus.cs
//Use this to attach aspects to GameObjects such as points toward the score,
//population points, credits the player earns for killing this unit, &c.

using UnityEngine;
using System.Collections;




public class Bonus : MonoBehaviour
{
	public int Points = 0;
	GameObject gameScore;
	GameScore score;
	Health healthScript;



	void Start()
	{
		gameScore = GameObject.Find("GameScore");
		score = gameScore.GetComponent<GameScore>();
	}


	public void AddPointsToPlayerScore()
	{
		score.CurrentScore += Points;
	}
}
