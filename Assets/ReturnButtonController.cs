using UnityEngine;
using System.Collections;

public class ReturnButtonController : MonoBehaviour {
	public SceneController sceneController;
	private bool isHovered = false;

	public void CanHome()
	{
		isHovered = true;
	}

	public void NoHome()
	{
		isHovered = false;
	}

	void Update()
	{
		if (isHovered && Input.GetButton ("Fire1"))
			sceneController.ToNextScene ("scene_chooser");
	}
}
