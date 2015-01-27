using UnityEngine;
using System.Collections;

public class FlashlightController : MonoBehaviour 
{
	public Light flashlightObject;
	
	// Use this for initialization
	void Start () 
	{
		flashlightObject.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			if(flashlightObject.enabled == false)
			{
				flashlightObject.enabled = true;
			}
			else
			{
				flashlightObject.enabled = false;
			}
		}
	}
}
