using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public GameObject claw; 
	public bool isShooting; 
	public Animator shooterAnimator; 
	public Claw clawScript;




	void Update () 
	{
		if(Input.GetButtonDown("Fire1") && !isShooting) 
		{
			LaunchClaw ();

		}
	}

	void LaunchClaw()
	{
		//Debug.Log ("test");
		isShooting = true;
		shooterAnimator.speed = 0;
		RaycastHit hit;
		Vector3 down = transform.TransformDirection (Vector3.down);

		//Raycast must hit oject in order to be true
		if (Physics.Raycast(transform.position, down, out hit, 100)) 
		{
			Debug.Log ("asjkdhask");
			claw.SetActive (true); //Activate claw
			clawScript.ClawTarget (hit.point); //launch towards target(balls)
		}


	}

	public void CollectedObject() //after hits object, shooter stops rotation and retracts
	{
		isShooting = false;
		shooterAnimator.speed = 0;
	}

}
