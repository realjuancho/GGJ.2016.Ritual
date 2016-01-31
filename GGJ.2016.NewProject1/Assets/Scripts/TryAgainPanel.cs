using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgainPanel : MonoBehaviour {


	public Text TryAgainText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TryAgain()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}

}
