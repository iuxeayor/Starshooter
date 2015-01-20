using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Health : MonoBehaviour 
{
	public float HP = 100f;
	public float MaxHP = 100f;

	//public Slider healthBar;

	

	public void ReduceHealth(float damageTaken)
	{
		HP -= damageTaken;
		//UpdateHealthBar();
	}



	public void IncreaseHealth(float healthApplied)
	{
		HP += healthApplied;
		//UpdateHealthBar();
	}


	
	/*public void UpdateHealthBar()
	{
		healthBar.value = HP/MaxHP;
	}*/
}
