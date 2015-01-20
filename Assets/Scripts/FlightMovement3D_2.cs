using UnityEngine;
using System.Collections;

public class FlightMovement3D_2 : MonoBehaviour 
{
	Vector3 v3LookAtPos;
	Vector3 v3SmoothedLookAtPos;

	public float MaxSpeed = 6000f;
	public float NormalSpeed = 3000f;
	public float MinSpeed = 500f;
	
	public float fForwardThrust = 3000;
	public float fRotateSpeed = 200;

	public bool bSpeedLock = false;  //true = speed is caught between max/min; false = no limits.

	private float fDelta;  //use for Time.deltaTime (prettier to look at).
	
	

	void Start () 
	{
		
	}

	void FixedUpdate () 
	{
		MostComplexControl();
	}

	
	
	void MostComplexControl()
	{
		fDelta = Time.deltaTime;
		
		Quaternion AddRot = Quaternion.identity;
		Vector3 AddPos = Vector3.forward;

		float Yaw = 0f;
		float Roll= 0f;
		float Pitch= 0f;

		if(Screen.lockCursor)
		{
			Yaw = Input.GetAxis("Yaw")*fRotateSpeed*fDelta;
			Roll = Input.GetAxis("Roll")*fRotateSpeed*fDelta;
			Pitch = Input.GetAxis("Pitch")*fRotateSpeed*fDelta;
		}



		if(Input.GetKeyDown("escape"))
		{
			Screen.lockCursor = false;
		}
		
		v3LookAtPos = new Vector3(Pitch, Yaw, Roll);
		
		v3SmoothedLookAtPos = Vector3.Lerp(v3SmoothedLookAtPos, v3LookAtPos, fDelta * 5);
		
		AddRot.eulerAngles = v3SmoothedLookAtPos;
		rigidbody.rotation *= AddRot;

		if(Input.GetAxis("Vertical") == 0)
		{
			if(fForwardThrust > NormalSpeed)
			{
				fForwardThrust -= 1000f * Time.deltaTime;
			}
			else if(fForwardThrust < NormalSpeed)
			{
				fForwardThrust += 1000f * Time.deltaTime;
			}
			else
			{
				fForwardThrust = NormalSpeed;
			}
		}

		
		//fForwardThrust += Input.GetAxis("Vertical") * 5f;  //original
		fForwardThrust += Input.GetAxis("Vertical") * 2000f * Time.deltaTime;

		if(bSpeedLock)
		{
			if(fForwardThrust < MinSpeed)
				fForwardThrust = MinSpeed;
			if(fForwardThrust > MaxSpeed)
				fForwardThrust = MaxSpeed;
		}

		AddPos = rigidbody.rotation * AddPos;
		rigidbody.velocity = AddPos * (-fForwardThrust * fDelta);
	}

	void OnMouseDown()
	{
		Screen.lockCursor = true;

	}

	void OnDestroy()
	{
		Screen.lockCursor = false;
	}
	
}










