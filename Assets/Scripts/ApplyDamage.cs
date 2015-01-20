using UnityEngine;
using System.Collections;



public class ApplyDamage : MonoBehaviour 
{
	public float DamagePoints = 5f;
	Health healthScript;
	HealthBar playerHealthBar;



	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			healthScript = col.gameObject.GetComponent<Health>();
			healthScript.ReduceHealth(DamagePoints);
			GameObject.Destroy(gameObject);
		}

		if(col.gameObject.tag == "Player")
		{
			healthScript = col.gameObject.GetComponent<Health>();
			playerHealthBar = col.gameObject.GetComponent<HealthBar>();

			healthScript.ReduceHealth(DamagePoints);
			playerHealthBar.UpdateHealthBar();

			GameObject.Destroy(gameObject);
		}

		if(col.gameObject.tag == "Asteroid")
		{
			healthScript = col.gameObject.GetComponent<Health>();
			healthScript.ReduceHealth(DamagePoints);
			GameObject.Destroy(gameObject);
		}

		if (col.gameObject.tag == "Ally") 
		{
			healthScript = col.gameObject.GetComponent<Health>();
			healthScript.ReduceHealth(DamagePoints);
			GameObject.Destroy(gameObject);
		}
		
	}
}