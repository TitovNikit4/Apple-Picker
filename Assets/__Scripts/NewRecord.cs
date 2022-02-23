using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRecord : MonoBehaviour {

	void Awake() {
		int score = PlayerPrefs.GetInt("ScoreEarned");
		int highScore = PlayerPrefs.GetInt("HighScore");
		if (score != highScore) {
			gameObject.SetActive(false);
		}
	}
}
