using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BogeySpawner : MonoBehaviour 
{
	public GameObject SpawnObject;          // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	public int MaxSpawnPopulation = 3;		// Maximum # of Bogeys to spawn at this point
	//int CurrentPopulation = 0;
	List <GameObject> BogeyPop = new List<GameObject>();
	
	
	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	
	void Spawn ()
	{
		if (BogeyPop.Count < MaxSpawnPopulation) 
		{
			// Find a random index between zero and one less than the number of spawn points.
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			GameObject newSpawn = (GameObject)Instantiate(SpawnObject, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
			newSpawn.GetComponent<BogeyManager>().Respawner = this;

			BogeyPop.Add(newSpawn);

			//CurrentPopulation++;
		}
	}


	void Respawn(BogeyManager thisEnemy)
	{
		BogeyPop.Remove(thisEnemy.gameObject);
		GameObject.Destroy (thisEnemy.gameObject);
	}



}
