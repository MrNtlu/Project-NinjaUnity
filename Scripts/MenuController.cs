using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	[SerializeField]
	private GameObject soundon,soundoff;

	private GameObject music;

	void Start(){
		music= GameObject.FindGameObjectWithTag ("Music");
		if (PlayerPrefs.GetInt ("Soundz") == 0) {
			//music.SetActive (true);
			//music.GetComponentInChildren<AudioSource> ().Play;
			soundon.SetActive (true);
			soundoff.SetActive (false);

		}
		if (PlayerPrefs.GetInt ("Soundz") == 1) {
			//music.SetActive (false);
			music.GetComponentInChildren<AudioSource> ().Stop ();
			soundon.SetActive (false);
			soundoff.SetActive (true);

		}
	}

	public void SoundOn(){
		PlayerPrefs.SetInt ("Soundz", 0);
		//music.SetActive (true);
		music.GetComponentInChildren<AudioSource> ().Play ();
		soundon.SetActive (true);
		soundoff.SetActive (false);
	}

	public void SoundOff(){
		PlayerPrefs.SetInt ("Soundz", 1);
		//music.SetActive (false);
		music.GetComponentInChildren<AudioSource> ().Stop ();
		soundon.SetActive (false);
		soundoff.SetActive (true);
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}


	public void Menu(){
		//level.music.Stop ();
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	}
		



	public void NextLevel(){
		Time.timeScale = 1f;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void MainMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene("Menu");

	}
}
