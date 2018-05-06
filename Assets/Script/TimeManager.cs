using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {
	public GameObject panel;
	public float startingTime;

	private static float countingTime;

	private Slider theSlide;

	// Use this for initialization
	void Start () {
		countingTime = startingTime;

		theSlide = GetComponent<Slider> ();
		theSlide.minValue = 0;
		theSlide.maxValue = (int)startingTime;

		panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		countingTime -= Time.deltaTime;
		if (countingTime > 100) {
			countingTime = 100;
		}
	
			if (countingTime <= 0) {
				panel.SetActive (true);
			Time.timeScale = 0;
			countingTime = startingTime;
			gameOverSystem.destroyEnemy ();
			}

			
			theSlide.value = countingTime/startingTime;
			Debug.Log (theSlide.value);

	}

	public static void addTime(){
		
	
			countingTime += 10;
	}

}
