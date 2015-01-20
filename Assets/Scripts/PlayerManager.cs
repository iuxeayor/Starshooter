using UnityEngine;
using System.Collections;



public class PlayerManager : MonoBehaviour
{
	Health healthScript;
	HealthBar healthBar;

	public float RegenRateInSec = .5f;
	public int RegenAmountInInts = 1;
	
	
	
	void Start ()
	{
		healthScript = GetComponent<Health>();
		healthBar = GetComponent<HealthBar>();
		StartCoroutine(Regenerate2());
	}

	
	void Update ()
	{
		if(healthScript.HP <= 0f)
		{
			if(tag == "Player")
			{
				Application.LoadLevel("Defeat Screen");
			}
			else
			{
				GameObject.Destroy(gameObject);
			}
		}

		//Regenerate();  //not using, better method with more control below.
	}


	
	IEnumerator Regenerate2()
	{
		while(true)
		{
			yield return new WaitForSeconds(RegenRateInSec);
			
			healthScript.IncreaseHealth(RegenAmountInInts);
			
			if(healthScript.HP >= healthScript.MaxHP)
			{
				healthScript.HP = healthScript.MaxHP;
			}
			
			healthBar.UpdateHealthBar();
		}
	}



	void Regenerate()
	{
		healthScript.IncreaseHealth(5*Time.deltaTime);
		healthBar.UpdateHealthBar();  //just in case I decide to use this later.
		
		if(healthScript.HP >= healthScript.MaxHP)
		{
			healthScript.HP = healthScript.MaxHP;
		}
	}



}
