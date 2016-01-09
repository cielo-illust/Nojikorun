using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TirleController : MonoBehaviour {
	public Text highScoreLabel;

	public void Start() {
		highScoreLabel.text = "HighScore : " + PlayerPrefs.GetInt ("HighScore") + "m";
	}
	public void OnStartButtonChecked () {
		SceneManager.LoadScene ("Main");
	}
}
