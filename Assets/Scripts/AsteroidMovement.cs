using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour 
{
	//public float fStartForceRange = .5f;
	//public float fStartTorqueRange = 1f;
	public float [] fForceSpeeds;
	public float [] fTorqueSpeeds;
	Vector3 v3StartForce = new Vector3(0, 0, 0);
	Vector3 v3StartTorque = new Vector3(0, 0, 0);



	void Start () 
	{
		/*v3StartForce = new Vector3(Random.Range(-fStartForceRange, fStartForceRange), Random.Range(-fStartForceRange, fStartForceRange), Random.Range(-fStartForceRange, fStartForceRange));
		v3StartTorque = new Vector3(Random.Range(-fStartTorqueRange, fStartTorqueRange), Random.Range(-fStartTorqueRange, fStartTorqueRange), Random.Range(-fStartTorqueRange, fStartTorqueRange));

		//ForceMode.Impulse gives only an instantaneous push - originally useful b/c asteroids didn't use drag, but now they do.
		rigidbody.AddForce(v3StartForce, ForceMode.Impulse);
		rigidbody.AddTorque(v3StartTorque, ForceMode.Impulse);*/

		int iSpeedChoice = 0;

		if (fForceSpeeds == null)
		{
			fForceSpeeds = new float[2]{10, 10};
		}

		if (fTorqueSpeeds == null) 
		{
			fTorqueSpeeds = new float[2]{10, 10};
		}


		//Set starting forces on the asteroids
		iSpeedChoice = Random.Range (0, fForceSpeeds.Length - 1);
		v3StartForce.x = fForceSpeeds [iSpeedChoice];

		iSpeedChoice = Random.Range (0, fForceSpeeds.Length - 1);
		v3StartForce.y = fForceSpeeds [iSpeedChoice];
		
		iSpeedChoice = Random.Range (0, fForceSpeeds.Length - 1);
		v3StartForce.z = fForceSpeeds [iSpeedChoice];


		//Set starting torque on the asteroids
		iSpeedChoice = Random.Range (0, fTorqueSpeeds.Length - 1);
		v3StartTorque.x = fTorqueSpeeds [iSpeedChoice];

		iSpeedChoice = Random.Range (0, fTorqueSpeeds.Length - 1);
		v3StartTorque.y = fTorqueSpeeds [iSpeedChoice];

		iSpeedChoice = Random.Range (0, fTorqueSpeeds.Length - 1);
		v3StartTorque.z = fTorqueSpeeds [iSpeedChoice];
	}



	void FixedUpdate () 
	{
		/*for (int i = 0; i < fTorqueSpeeds.Length; i++) 
		{
			v3StartTorque.y = fTorqueSpeeds[i];
		}*/

		rigidbody.AddForce(v3StartForce, ForceMode.Force);
		rigidbody.AddTorque(v3StartTorque, ForceMode.Force);
	}
}



















