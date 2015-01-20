using UnityEngine;
using System.Collections;

public class OnBogeyDeath : MonoBehaviour 
{
	public GameObject Explosion;
	public static bool quitting = false;



	void OnApplicationQuit()
	{
		quitting = true;
	}



	void OnDestroy()
	{
		if(!quitting && !Application.isLoadingLevel)
		{
			GameObject explode = Instantiate(Explosion, transform.position, transform.rotation) as GameObject;
			explode.rigidbody.AddForce(rigidbody.velocity, ForceMode.VelocityChange);
		}
	}
}
