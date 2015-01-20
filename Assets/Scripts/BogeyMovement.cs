using UnityEngine;
using System.Collections;

public class BogeyMovement : MonoBehaviour 
{
	public Vector3 Velocity = new Vector3(0, 0, 1);
	public Vector3 Rotations = new Vector3(0, 0, 0);

	private float fDelta;

	void Start () 
	{
		
	}

	void FixedUpdate () 
	{
		fDelta = Time.deltaTime;
		Vector3 AddPos = Vector3.forward;
		
		AddPos = rigidbody.rotation * AddPos;
		rigidbody.velocity = AddPos * (Velocity.z * fDelta);
	}
}
