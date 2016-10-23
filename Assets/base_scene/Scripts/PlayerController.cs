using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public GameObject mainCam;

	public float moveSpeed;

	private float multiplier;
	private Vector3 curDir, prevDir;

	// Use this for initialization
	void Awake ()
	{
		UpdateDirs();
		multiplier = 1.0f;
	}

	void UpdateDirs()
	{
		prevDir = curDir;
		curDir = Vector3.Scale(mainCam.transform.forward, new Vector3(1f, 0, 1f));
		if (Vector3.Angle (curDir, prevDir) >= 3f)
			multiplier = 1.0f;
		else
			multiplier += 0.1f;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButton ("Fire1")) {
			UpdateDirs ();
			Vector3 forward = curDir * multiplier;
			transform.position = transform.position + (forward * moveSpeed * Time.deltaTime);
		}
		if (Input.GetKeyDown (KeyCode.M) ){
			Application.CaptureScreenshot("bouncy_screen.png");
		}
	}
}

