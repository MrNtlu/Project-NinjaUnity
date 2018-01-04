using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckMarkLevel : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "Player"){
			int sceneid=SceneManager.GetActiveScene().buildIndex;

			if (sceneid == 2) {
				PlayerPrefs.SetInt ("Level1", 2);
			}if (sceneid == 3) {
				PlayerPrefs.SetInt ("Level2", 3);
			}if (sceneid == 4) {
				PlayerPrefs.SetInt ("Level3", 4);
			}if (sceneid == 5) {
				PlayerPrefs.SetInt ("Level4", 5);
			}if (sceneid == 6) {
				PlayerPrefs.SetInt ("Level5", 6);
			}if (sceneid == 7) {
				PlayerPrefs.SetInt ("Level6", 7);
			}if (sceneid == 8) {
				PlayerPrefs.SetInt ("Level7", 8);
			}if (sceneid == 9) {
				PlayerPrefs.SetInt ("Level8", 9);
			}if (sceneid == 10) {
				PlayerPrefs.SetInt ("Level9", 10);
			}if (sceneid == 11) {
				PlayerPrefs.SetInt ("Level10", 11);
			}if (sceneid == 12) {
				PlayerPrefs.SetInt ("Level11", 12);
			}if (sceneid == 13) {
				PlayerPrefs.SetInt ("Level12", 13);
			}if (sceneid == 14) {
				PlayerPrefs.SetInt ("Level13", 14);
			}if (sceneid == 15) {
				PlayerPrefs.SetInt ("Level14", 15);
			}if (sceneid == 16) {
				PlayerPrefs.SetInt ("Level15", 16);
			}if (sceneid == 17) {
				PlayerPrefs.SetInt ("Level16", 17);
			}if (sceneid == 18) {
				PlayerPrefs.SetInt ("Level17", 18);
			}if (sceneid == 19) {
				PlayerPrefs.SetInt ("Level18", 19);
			}if (sceneid == 20) {
				PlayerPrefs.SetInt ("Level19", 20);
			}if (sceneid == 21) {
				PlayerPrefs.SetInt ("Level20", 21);
			}if (sceneid == 22) {
				PlayerPrefs.SetInt ("Level21", 22);
			}if (sceneid == 23) {
				PlayerPrefs.SetInt ("Level22", 23);
			}if (sceneid == 24) {
				PlayerPrefs.SetInt ("Level23", 24);
			}if (sceneid == 25) {
				PlayerPrefs.SetInt ("Level24", 25);
			}if (sceneid == 26) {
				PlayerPrefs.SetInt ("Level25", 26);
			}if (sceneid == 27) {
				PlayerPrefs.SetInt ("Level26", 27);
			}if (sceneid == 28) {
				PlayerPrefs.SetInt ("Level27", 28);
			}if (sceneid == 29) {
				PlayerPrefs.SetInt ("Level28", 29);
			}if (sceneid == 30) {
				PlayerPrefs.SetInt ("Level29", 30);
			}if (sceneid == 31) {
				PlayerPrefs.SetInt ("Level30", 31);
			}
		}
	}
}
