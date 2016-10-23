using UnityEngine;
using UnityEngine.Internal;
using System.Collections;

public class BallSpawnController : MonoBehaviour {

	public GameObject ballFab;

	public float spawnRange;

	public float spawnRate;

	// Use this for initialization
	void Awake () {
		SpawnBall ();
	}

	// Update is called once per frame
	void SpawnBall () {
		Vector3 spawnOffset = new Vector3 (Random.Range (0, spawnRange),
			0, Random.Range (0, spawnRange));
		Instantiate (ballFab, transform.position + spawnOffset, Quaternion.identity);
		Invoke ("SpawnBall", spawnRate);
	}
}

