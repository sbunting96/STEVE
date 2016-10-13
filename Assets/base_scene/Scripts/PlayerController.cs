using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public GameObject mainCam;

	public float moveSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton ("Fire1")) {
			Vector3 forward = new Vector3 (mainCam.transform.forward.x, 0,
				mainCam.transform.forward.z);
			transform.position = transform.position + (forward * moveSpeed * Time.deltaTime);
		}
	}
}

