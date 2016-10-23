using UnityEngine;
using System.Collections;

public class PortalController : MonoBehaviour {

	public static SceneController sceneController;
	public string sceneName;

	private bool triggerActive = false;

	void Awake()
	{
		sceneController = SceneController.instance;
	}

	public void CanTP()
	{
		triggerActive = true;
	}

	public void NoTP()
	{
		triggerActive = false;
	}

	void Update()
	{
		if (triggerActive && Input.GetButton("Fire1"))
			sceneController.ToNextScene (sceneName);
	}
}
