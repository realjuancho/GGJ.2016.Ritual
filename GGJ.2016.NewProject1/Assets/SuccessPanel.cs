using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SuccessPanel : MonoBehaviour {


	public void LoadNextLevel()
	{
		int i = SceneManager.GetAllScenes().Length;

		if(SceneManager.GetActiveScene().buildIndex < i)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		}
		else
		{

		}

	}

	
}
