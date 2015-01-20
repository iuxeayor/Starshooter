using UnityEngine;
using System.Collections;

public class OnAsteroidDestroyed : MonoBehaviour 
{
	public static bool quitting = false;
	public GameObject [] Explosions;
	public GameObject [] AsteroidRemnants;
	public Transform [] Locations;  //for now, Asteroids and Explosions will spawn at the same points. Update later.
	
	
	
	void OnApplicationQuit()
	{
		quitting = true;
	}
	
	
	
	void OnDestroy()
	{
		if(!quitting && !Application.isLoadingLevel)
		{
			if(Explosions.Length > 0)
			{
				for(int i = 0; i < Explosions.Length; i++)
				{
					GameObject explode = Instantiate(Explosions[i], Locations[i].position, Locations[i].rotation) as GameObject;
					explode.rigidbody.AddForce(rigidbody.velocity, ForceMode.VelocityChange);
				}
			}

			if(AsteroidRemnants.Length > 0)
			{
				for(int i = 0; i < AsteroidRemnants.Length; i++)
				{
					GameObject pieces = Instantiate(AsteroidRemnants[i], Locations[i].position, Locations[i].rotation) as GameObject;
					pieces.rigidbody.AddForce(rigidbody.velocity, ForceMode.VelocityChange);
				}
			}
		}
	}
}
