using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEarned : MonoBehaviour {

	void Awake() {
		int score = PlayerPrefs.GetInt("ScoreEarned");
		this.GetComponent<Text>().text = "Your score: " + score;
	}
}
