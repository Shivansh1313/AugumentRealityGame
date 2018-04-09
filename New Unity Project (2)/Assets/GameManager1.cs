using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Configuration;
using UnityEngine.SceneManagement;


public class GameManager1 : MonoBehaviour {

	public static GameManager1 Instance {set; get;}

	private void Awake()
	{
		Instance = this;
		DontDestroyOnLoad (this.gameObject);
	
		ChangeScene ("Menu");
	}

	public void ChangeScene(string sceneName)
	{
	
		SceneManager.LoadScene (sceneName);
	}

}
