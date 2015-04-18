﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SceneManager : MonoBehaviour {
	public Text panelText;
	private string panelTextString;
	private Canvas EndRace;
	// Use this for initialization
	void Awake () {
		//panelText = gameObject.GetComponent<Text> ();
		EndRace = GameObject.FindGameObjectWithTag ("endRaceCanvas").GetComponent<Canvas>();
		EndRace.enabled = false;
	}

	void Update () {
		if (GameObject.FindGameObjectWithTag("endRaceCanvas").GetComponent<Canvas>().enabled) {
			panelText.text = panelTextString;
		}
	}

	public void AddTimeForDisplay(float time, string name){
		panelTextString += name + ":  " + time + "\n";
	}

}
