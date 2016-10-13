using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour
{

	public GameObject subject;

	private bool rotating;

	// Use this for initialization
	void Awake ()
	{
		rotating = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (rotating)
			transform.RotateAround (subject.transform.position, Vector3.left, 0.5f);
	}

	public void StartRotating()
	{
		rotating = true;
	}

	public void StopRotating()
	{
		rotating = false;
	}
}

