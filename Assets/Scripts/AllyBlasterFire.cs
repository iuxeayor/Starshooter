using UnityEngine;
using System.Collections;



public class AllyBlasterFire : BlasterFire 
{
	public Transform [] Blastpoints;
	
	
	
	void Start()
	{
		
	}
	
	
	
	void Update () 
	{
		
	}
	
	
	
	public void Shoot()
	{
		Rigidbody newBlast = Instantiate(rBlasterBolt, Blastpoints[0].position, Blastpoints[0].rotation) as Rigidbody;
		newBlast.AddForce(Blastpoints[0].forward * fVelocity, ForceMode.VelocityChange);
		
		Rigidbody newBlast2 = Instantiate(rBlasterBolt, Blastpoints[1].position, Blastpoints[1].rotation) as Rigidbody;
		newBlast2.AddForce(Blastpoints[1].forward * fVelocity, ForceMode.VelocityChange);
		
		Destroy(newBlast.gameObject, blasterLife);
		Destroy(newBlast2.gameObject, blasterLife);
	}
}
