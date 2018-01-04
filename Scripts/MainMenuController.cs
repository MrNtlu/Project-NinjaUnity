using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {
	[SerializeField]
	private AudioSource music;

	[SerializeField]
	private GameObject boss,soundon,soundoff;

	[SerializeField]
	private Animator anim;


	void Start(){
		if (PlayerPrefs.GetInt ("SoundCont") == 0) {
			music.Play ();
			soundon.SetActive (true);
			soundoff.SetActive (false);

		}
		if (PlayerPrefs.GetInt ("SoundCont") == 1) {
			music.Stop ();
			soundon.SetActive (false);
			soundoff.SetActive (true);

		}
		if (PlayerPrefs.GetInt ("Rate") == 1) {
			RateUsPanel.SetActive (false);
			closerateusbutton.SetActive (false);

		}

		if (GameObject.FindGameObjectsWithTag ("Music").Length >= 2) {
			GameObject[] musics = GameObject.FindGameObjectsWithTag ("Music");
			GameObject.Destroy (musics [0]);

		}
	}

	public void SoundOn(){
		PlayerPrefs.SetInt ("SoundCont", 0);
		music.Play ();
		soundon.SetActive (true);
		soundoff.SetActive (false);
	}

	public void SoundOff(){
		PlayerPrefs.SetInt ("SoundCont", 1);
		music.Stop ();
		soundon.SetActive (false);
		soundoff.SetActive (true);
	}

	public void RateUs(){
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.ProjectNinja");
	}

	[SerializeField]
	private GameObject RateUsPanel;

	[SerializeField]
	private GameObject closerateusbutton;

	public void CloseRateUs(){
		PlayerPrefs.SetInt ("Rate", 1);
		RateUsPanel.SetActive (false);
		closerateusbutton.SetActive (false);
	}


		

	public void Customization(){
		DontDestroyOnLoad (music);
		boss.transform.eulerAngles = new Vector2 (0, 180);
		anim.SetInteger ("MenuAnim", 2);
		StartCoroutine (CustomStart ());
	}

	IEnumerator CustomStart(){
		yield return new WaitForSeconds (1.15f);
		SceneManager.LoadScene ("Custimization");
	}


	[SerializeField]
	private GameObject creditspanel;

	public void Credits(){
		if (creditspanel.activeInHierarchy == true)
			creditspanel.SetActive (false);
		else
			creditspanel.SetActive (true);
			
	}


	public void LevelsMenu(){
		anim.SetInteger ("MenuAnim", 2);
		StartCoroutine (LevelStart ());
	}


		
	IEnumerator LevelStart(){
		yield return new WaitForSeconds (1.15f);
		SceneManager.LoadScene ("Levels");
	}

}
