using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour 
{
	public Vector3 v3TeleportPosition = new Vector3(0, 0, 0);

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{
		other.transform.position = v3TeleportPosition;

	}
}
