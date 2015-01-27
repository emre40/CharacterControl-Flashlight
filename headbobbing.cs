using UnityEngine;  
using System.Collections;  

public class headbobbing : MonoBehaviour  
{  
	private float StartY; // The default local Y coordinate of a camera  
	private float Angle = 0; // The angle for our sinusoid  
	public float BobAmount; // The maximal bobbing delta Y  
	public float BobbingSpeed; // The speed with which we will change our Angle  
	public CharacterController Controller; // The character controller we will use to get the speed of our character  
	
	void Start ()  
	{  
		StartY = transform.localPosition.y;  
		Controller = transform.parent.gameObject.GetComponent<CharacterController> (); // We use transform.parent.gameObject because the camera is parented to the game object of our character  
	}  
	
	void Update ()  
	{  
		if ((Mathf.Abs (Controller.velocity.x) > 0.5f) || (Mathf.Abs (Controller.velocity.z) > 0.5f)) {  
			transform.localPosition = new Vector3 (0, StartY + BobAmount * Mathf.Sin (Angle), 0);  
			Angle += BobbingSpeed * Time.deltaTime;  
			if (Angle >= 2 * Mathf.PI)  
				Angle = 0;  
		} else {  
			Angle = 0;  
			transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3 (0, StartY, 0), 0.1f);  
		}  
	}  
}
