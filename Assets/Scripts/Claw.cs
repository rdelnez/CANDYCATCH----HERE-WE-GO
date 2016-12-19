using UnityEngine;
using System.Collections;

public class Claw : MonoBehaviour {


	public Transform origin; 
	public float speed =5f; 
	public Gun gun; 



	public ScoreManager scoreManager;

	public Vector3 target; 
	public int ballValue = 100;
	public GameObject childObject; 
	public LineRenderer lineRenderer;
	public bool hitBall;
	public bool retracting; 

	void Awake () 
	{
			
		lineRenderer = GetComponent<LineRenderer> ();
	}
	

	void Update () 
	{
		float step = speed * Time.deltaTime; 
		transform.position = Vector3.MoveTowards(transform.position, target, step);
		lineRenderer.SetPosition(0, origin.position);
		lineRenderer.SetPosition(1, transform.position);
		if (transform.position == origin.position && retracting) 
		{
			gun.CollectedObject ();
			if (hitBall) 
			{
				
				scoreManager.AddPoints (ballValue);
				hitBall = false;
			}
			Destroy(childObject);
			gameObject.SetActive (false);
		}
	}

	public void ClawTarget (Vector3 pos)

	{
		target = pos;
	}

	void OnTriggerEnter (Collider other)
	{
		
		retracting = true;
		target = origin.position;

			if (other.gameObject.CompareTag ("balls"))
			{
			Debug.Log ("Hit");

				hitBall = true;
				childObject = other.gameObject;
				other.transform.SetParent (this.transform);
			}

				//else if (other.gameObject.CompareTag("Rock"))
			//{
			//	childObject = other.gameObject;
			//	other.transform.SetParent(this.transform);
			}
	//}
}
