using UnityEngine;
using System.Collections;

public class ExplosionManager : MonoBehaviour
{
	public float KillExplosionObjectAfterSec = 5;
	
	
	
	void Update ()
	{
		Destroy (gameObject, KillExplosionObjectAfterSec);
	}
}
