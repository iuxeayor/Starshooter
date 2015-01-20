using UnityEngine;
using System.Collections;

public class CapitalShipMovement : MonoBehaviour 
{
	public Vector3 Velocity = new Vector3(0, 0, 1);
	public Vector3 Rotations = new Vector3(0, 0, 0);

	public Transform target;
	float fTurnSpeed = .1f;

	void Start () 
	{
		rigidbody.AddForce(Velocity, ForceMode.VelocityChange);
		rigidbody.AddTorque(Rotations, ForceMode.VelocityChange);
	}



	void Update () 
	{
		if(target != null)
		{
			Vector3 v3TargetPoint = target.position - transform.position;
			Quaternion targetQuat = new Quaternion();
			Vector3 AddPos = Vector3.forward;

			float step = fTurnSpeed * Time.deltaTime;

			targetQuat = Quaternion.LookRotation(v3TargetPoint, Vector3.up);
			transform.rotation = Quaternion.Slerp(transform.rotation, targetQuat, step);

			AddPos = rigidbody.rotation * AddPos;
			rigidbody.velocity = AddPos * (Velocity.z * Time.deltaTime);
		}
	}
}
