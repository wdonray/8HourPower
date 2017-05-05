using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartorExit : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
        SceneManager.LoadScene("0.main");
	}
	
	// Update is called once per frame
	public void ExitGame() {
        Application.Quit();
	}
}
