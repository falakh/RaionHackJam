using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TextPlayerCoin : MonoBehaviour {
    
	
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = PlayerData.getKoin().ToString();
	}
}
