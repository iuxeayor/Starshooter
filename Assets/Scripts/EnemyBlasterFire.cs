using UnityEngine;
using System.Collections;



public class EnemyBlasterFire : BlasterFire
{
	void Start()
	{

	}
	


	void Update () 
	{
		
	}



	public void Shoot()
	{
		Rigidbody newBlast = Instantiate(rBlasterBolt, transform.position, transform.rotation) as Rigidbody;
		newBlast.AddForce(transform.forward * fVelocity, ForceMode.VelocityChange);
		
		Destroy(newBlast.gameObject, blasterLife);
	}
}
