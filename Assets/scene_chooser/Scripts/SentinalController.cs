using UnityEngine;
using System.Collections;

public class SentinalController : MonoBehaviour {

	public int numSentinals;
	public float orbitRate, orbitDistance, initialPitch, initialYaw, initialRoll;
	public GameObject sentinalFab;

	private float sentinalOffset;
	private GameObject[] sentinals;

	// Use this for initialization
	void Awake () {
		sentinalOffset = 360f / numSentinals;
		Quaternion initialOrientation =  Quaternion.Euler (transform.eulerAngles + new Vector3(initialPitch, initialYaw, initialRoll));
		Vector3 initialPosition = transform.position + new Vector3 (orbitDistance, 0, 0);
		sentinals = new GameObject[numSentinals];
		for(int i = 0; i < numSentinals; i++)
		{
			sentinals[i] = (GameObject)Instantiate (sentinalFab, initialPosition, initialOrientation);
			sentinals [i].transform.RotateAround (transform.position, transform.up, sentinalOffset * i);
		}
	}

	void FixedUpdate() {
		//thisSentinal.transform.localRotation = Quaternion.Euler (transform.eulerAngles + new Vector3(initialPitch, initialYaw, initialRoll));
		foreach (GameObject sentinal in sentinals) {
			sentinal.transform.RotateAround (transform.position, transform.up, orbitRate);
		}
	}
}
