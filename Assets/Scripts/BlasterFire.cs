using UnityEngine;
using System.Collections;



public class BlasterFire : MonoBehaviour 
{
	public Rigidbody rBlasterBolt;
	public float fVelocity = 200.0f;
	public float blasterLife = 3f;
	protected Health healthScript;



	void Start()
	{

	}



	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody newBlast = Instantiate(rBlasterBolt, transform.position, transform.rotation) as Rigidbody;
			newBlast.AddForce(transform.forward * fVelocity, ForceMode.VelocityChange);

			Destroy(newBlast.gameObject, blasterLife);
		}
	}
}
