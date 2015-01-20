//BogeyManager.cs
//This script handles all the interactions between variables that
//are used throughout the Bogey liftime and affect each other
//in ways that should not be handled locally:
//	Health should not handle the Bonus items dropped upon death.

using UnityEngine;
using System.Collections;



public class BogeyManager : MonoBehaviour
{
	Health healthScript;
	Bonus bonusScript;
	//public GameObject Explosion;
	public BogeySpawner Respawner;



	void Start ()
	{
		healthScript = GetComponent<Health>();
		bonusScript = GetComponent<Bonus>();
	}



	void Update ()
	{
		if(healthScript.HP <= 0f)
		{
			//GameObject explode = Instantiate(Explosion, transform.position, transform.rotation) as GameObject;
			//explode.rigidbody.AddForce(rigidbody.velocity, ForceMode.VelocityChange);

			bonusScript.AddPointsToPlayerScore();
			Respawner.SendMessage("Respawn", this);
			//GameObject.Destroy(gameObject);  //moved to the respawner
		}
	}
}
