using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public GameObject mainCam;

	public float moveSpeed;

	private Vector3 curDir, curRot;
	private Vector2 mouseRot;
	private int moveForward, moveBackward, moveLeft, moveRight;

	// Use this for initialization
	void Awake ()
	{
		moveForward = 0;
		moveBackward = 0;
		moveLeft = 0;
		moveRight = 0;
		curDir = mainCam.transform.forward;
		curRot = mainCam.transform.eulerAngles;
		mouseRot = new Vector2 ();
	}

	void FixedUpdate()
	{
		curRot = mainCam.transform.eulerAngles;
		curDir = mainCam.transform.forward;
		Vector3 rotset = new Vector3 (mouseRot.x, mouseRot.y, 0);
		Vector3 fOffset = curDir * (moveForward - moveBackward);
		Vector3 sOffset = mainCam.transform.right * (moveRight - moveLeft);
		Vector3 offset = (fOffset + sOffset).normalized * moveSpeed;

		mainCam.transform.eulerAngles = curRot + rotset;
		transform.position += offset;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.W))
			moveForward = 1;
		else
			moveForward = 0;
		
		if (Input.GetKey (KeyCode.A))
			moveLeft = 1;
		else
			moveLeft = 0;
		
		if (Input.GetKey (KeyCode.S))
			moveBackward = 1;
		else
			moveBackward = 0;
		
		if (Input.GetKey (KeyCode.D))
			moveRight = 1;
		else
			moveRight = 0;
		mouseRot.Set(-Input.GetAxis ("Mouse Y"), Input.GetAxis ("Mouse X"));
	}
}

