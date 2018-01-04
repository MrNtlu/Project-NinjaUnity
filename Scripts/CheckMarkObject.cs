using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMarkObject : MonoBehaviour {


	[SerializeField]
	private GameObject[] checkmark;

	void Start () {
		if (PlayerPrefs.GetInt("Level1")==2) {
			checkmark [1].SetActive (false);
		}if (PlayerPrefs.GetInt("Level2")==3) {
			checkmark [2].SetActive (false);
		}if (PlayerPrefs.GetInt("Level3")==4) {
			checkmark [3].SetActive (false);
		}if (PlayerPrefs.GetInt("Level4")==5) {
			checkmark [4].SetActive (false);
		}if (PlayerPrefs.GetInt("Level5")==6) {
			checkmark [5].SetActive (false);
		}if (PlayerPrefs.GetInt("Level6")==7) {
			checkmark [6].SetActive (false);
		}if (PlayerPrefs.GetInt("Level7")==8) {
			checkmark [7].SetActive (false);
		}if (PlayerPrefs.GetInt("Level8")==9) {
			checkmark [8].SetActive (false);
		}if (PlayerPrefs.GetInt("Level9")==10) {
			checkmark [9].SetActive (false);
		}if (PlayerPrefs.GetInt("Level10")==11) {
			checkmark [10].SetActive (false);
		}if (PlayerPrefs.GetInt("Level11")==12) {
			checkmark [11].SetActive (false);
		}if (PlayerPrefs.GetInt("Level12")==13) {
			checkmark [12].SetActive (false);
		}if (PlayerPrefs.GetInt("Level13")==14) {
			checkmark [13].SetActive (false);
		}if (PlayerPrefs.GetInt("Level14")==15) {
			checkmark [14].SetActive (false);
		}if (PlayerPrefs.GetInt("Level15")==16) {
			checkmark [15].SetActive (false);
		}if (PlayerPrefs.GetInt("Level16")==17) {
			checkmark [16].SetActive (false);
		}if (PlayerPrefs.GetInt("Level17")==18) {
			checkmark [17].SetActive (false);
		}if (PlayerPrefs.GetInt("Level18")==19) {
			checkmark [18].SetActive (false);
		}if (PlayerPrefs.GetInt("Level19")==20) {
			checkmark [19].SetActive (false);
		}if (PlayerPrefs.GetInt("Level20")==21) {
			checkmark [20].SetActive (false);
		}if (PlayerPrefs.GetInt("Level21")==22) {
			checkmark [21].SetActive (false);
		}if (PlayerPrefs.GetInt("Level22")==23) {
			checkmark [22].SetActive (false);
		}if (PlayerPrefs.GetInt("Level23")==24) {
			checkmark [23].SetActive (false);
		}if (PlayerPrefs.GetInt("Level24")==25) {
			checkmark [24].SetActive (false);
		}if (PlayerPrefs.GetInt("Level25")==26) {
			checkmark [25].SetActive (false);
		}if (PlayerPrefs.GetInt("Level26")==27) {
			checkmark [26].SetActive (false);
		}if (PlayerPrefs.GetInt("Level27")==28) {
			checkmark [27].SetActive (false);
		}if (PlayerPrefs.GetInt("Level28")==29) {
			checkmark [28].SetActive (false);
		}if (PlayerPrefs.GetInt("Level29")==30) {
			checkmark [29].SetActive (false);
		}if (PlayerPrefs.GetInt("Level30")==31) {
			checkmark [30].SetActive (false);
		}
	}

}
