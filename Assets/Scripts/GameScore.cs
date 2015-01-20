//GameScore.cs
//This applies to the overall score of the game.  Any individual accomplishments
//should be handled in another script and attached to the individual GameObject.

using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class GameScore : MonoBehaviour
{
	public int CurrentScore = 0;
	public int TotalScore = 100;
	float CurrentSpeedValue;

	public GameObject Starshooter;
	FlightMovement3D_2 SpeedValue;

	public Text scoreText;
	public Text maxScoreText;
	public Text CurrentSpeed;



	void Start()
	{
		SpeedValue = Starshooter.GetComponent<FlightMovement3D_2> ();
		CurrentSpeedValue = SpeedValue.fForwardThrust;

		scoreText.text = "Score: " + CurrentScore.ToString();
		maxScoreText.text = "Max Score: " + TotalScore.ToString();
		CurrentSpeed.text = "Speed: " + CurrentSpeedValue.ToString();
	}



	void Update ()
	{
		CurrentSpeedValue = SpeedValue.fForwardThrust;

		scoreText.text = "Score: " + CurrentScore.ToString();
		maxScoreText.text = "Max Score: " + TotalScore.ToString();
		CurrentSpeed.text = "Speed: " + CurrentSpeedValue.ToString();



		if(CurrentScore >= TotalScore)
		{
			Application.LoadLevel("Victory Screen");
			//GameObject.Destroy(Starshooter);
		}
	}
}
