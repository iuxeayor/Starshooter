using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{
	public Slider healthBar;
	public Text HPtext;

	private Health playerHP;



	void Start()
	{
		playerHP = GetComponent<Health>();
		HPtext.text = playerHP.HP.ToString();
	}



	public void UpdateHealthBar()
	{
		healthBar.value = playerHP.HP/playerHP.MaxHP;
		HPtext.text = playerHP.HP.ToString();
	}
}
