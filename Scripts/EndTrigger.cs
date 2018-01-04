using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour {
	[SerializeField]
	private GameObject levelcompletepanel;


	void AdShower () {
		int RandomNum =Random.Range (0, 100);
		if (RandomNum <= 47) {
			Advertisement.Initialize ("1530333", true);
			StartCoroutine (ShowAdWhenReady ());
		}

	}

	IEnumerator ShowAdWhenReady(){
		while (!Advertisement.IsReady ())
			yield return null;
		Advertisement.Show ();
	}

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player"){
			AdShower ();
			int sceneid=SceneManager.GetActiveScene().buildIndex;
			//PlayerPrefs.SetInt ("Levels", sceneid);
			if (sceneid > PlayerPrefs.GetInt ("Levels")) {
				PlayerPrefs.SetInt ("Levels", sceneid);
			} else if (sceneid < PlayerPrefs.GetInt ("Levels")) {
				
			} else if (sceneid <= 1) {
				PlayerPrefs.SetInt ("Level", 2);
			}

			Time.timeScale = 0f;
			levelcompletepanel.SetActive (true);
		}
	}

	//IEnumerator NextLevel(){
		//yield return new WaitForSeconds (1);
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	//}

}
