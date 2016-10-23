using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
	public float lifeTime;
	// Use this for initialization
	void Awake ()
	{
		Invoke ("Die", lifeTime);
	}

	void Die()
	{
		Destroy (gameObject);
	}
}

