using UnityEngine;
using System.Collections;

public class AsteroidExplosionScript : MonoBehaviour
{
	public float KillExplosionObjectAfterSec = 5;



	void Update ()
	{
		Destroy (gameObject, KillExplosionObjectAfterSec);
	}
}
