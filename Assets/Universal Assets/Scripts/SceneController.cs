using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneController : MonoBehaviour {

	public static SceneController instance;

	private Scene prevScene, curScene;

	// Use this for initialization
	void Awake () {
		if (instance != null)
			Destroy (this);
		else
			instance = this;

		curScene = SceneManager.GetActiveScene ();
	}

	public void ToNextScene(string sceneName)
	{
		Debug.Log ("at tonextscene");
		prevScene = curScene;
		SceneManager.LoadScene (sceneName);
	}

}
