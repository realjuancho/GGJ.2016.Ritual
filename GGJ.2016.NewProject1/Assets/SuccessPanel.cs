using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SuccessPanel : MonoBehaviour {


	public void LoadNextLevel()
	{
		
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		

	}

	
}
