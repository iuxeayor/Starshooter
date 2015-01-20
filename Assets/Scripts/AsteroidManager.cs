using UnityEngine;
using System.Collections;



public class AsteroidManager : MonoBehaviour
{
	Health healthScript;
	Bonus bonusScript;
	//public GameObject AsteroidExplosion;
	

	
	void Start ()
	{
		healthScript = GetComponent<Health>();
		bonusScript = GetComponent<Bonus>();
	}
	
	
	
	void Update ()
	{
		if(healthScript.HP <= 0f)
		{
			//GameObject explode = Instantiate(AsteroidExplosion, transform.position, transform.rotation) as GameObject;
			bonusScript.AddPointsToPlayerScore();
			GameObject.Destroy(gameObject);
		}
	}
}
