using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goHome : MonoBehaviour {

	// Use this for initialization
	public void tekan(){
		SceneManager.LoadSceneAsync (0);
	}
}
