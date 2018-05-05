using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

	public float startingTime;
	private static float countingTime;

	private Text theText;

	// Use this for initialization
	void Start () {
		countingTime = startingTime;

		theText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (countingTime > 0) {

			countingTime -= Time.deltaTime;

			if (countingTime == 0) {

			}

			theText.text = "" + Mathf.Round (countingTime);
		}
	}

	public static void addTime(){
		countingTime += 10;
	}

}
