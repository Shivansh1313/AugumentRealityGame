using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuManager : MonoBehaviour {

	public void OnPlayButtonClick()
	{
	
		GameManager1.Instance.ChangeScene ("trump1");
		  
	}
}
