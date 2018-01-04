using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomEdit : MonoBehaviour {

	[SerializeField]
	GameObject torso1,torso2,head1,head2,hood1,hood2,pelvis1,pelvis2,wrist1left,
	wrist2left,shoulder1left,shoulder2left,wrist1right,wrist2right,shoulder1right,shoulder2right,elbowleft1,elbowlleft2,elbowright1,elbowright2,
	wrist3left,shoulder3left,elbow3left,wrist3right,shoulder3right,elbow3right;

	void Start(){
		if (PlayerPrefs.GetInt ("Torso") == 1) {
			torso1.SetActive (true);
			torso2.SetActive (false);
			torso3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Torso") == 2) {
			torso1.SetActive (false);
			torso2.SetActive (true);
			torso3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Torso") == 3) {
			torso1.SetActive (false);
			torso2.SetActive (false);
			torso3.SetActive (true);

		}

		if (PlayerPrefs.GetInt ("Head") == 1) {
			head1.SetActive (true);
			head2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Head") == 2) {
			head1.SetActive (false);
			head2.SetActive (true);

		}

		if (PlayerPrefs.GetInt ("Hood") == 1) {
			hood1.SetActive (true);
			hood2.SetActive (false);
			hood3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Hood") == 2) {
			hood1.SetActive (false);
			hood2.SetActive (true);
			hood3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Hood") == 3) {
			hood1.SetActive (false);
			hood2.SetActive (false);
			hood3.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Pelvis") == 1) {
			pelvis1.SetActive (true);
			pelvis2.SetActive (false);
			pelvis3.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Pelvis") == 2) {
			pelvis1.SetActive (false);
			pelvis2.SetActive (true);
			pelvis3.SetActive (false);
		}

		if (PlayerPrefs.GetInt ("Pelvis") == 3) {
			pelvis1.SetActive (false);
			pelvis2.SetActive (false);
			pelvis3.SetActive (true);
		}

		if (PlayerPrefs.GetInt ("WristShoulder") == 1) {
			wrist1left.SetActive (true);
			wrist2left.SetActive (false);
			shoulder1left.SetActive (true);
			shoulder2left.SetActive (false);
			wrist1right.SetActive (true);
			wrist2right.SetActive (false);
			shoulder1right.SetActive (true);
			shoulder2right.SetActive (false);
			elbowleft1.SetActive (true);
			elbowlleft2.SetActive (false);
			elbowright1.SetActive (true);
			elbowright2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("WristShoulder") == 2) {
			wrist1left.SetActive (false);
			wrist2left.SetActive (true);
			wrist3left.SetActive (false);
			shoulder1left.SetActive (false);
			shoulder2left.SetActive (true);
			shoulder3left.SetActive (false);
			wrist1right.SetActive (false);
			wrist2right.SetActive (true);
			wrist3right.SetActive (false);
			shoulder1right.SetActive (false);
			shoulder2right.SetActive (true);
			shoulder3right.SetActive (false);
			elbowleft1.SetActive (false);
			elbowlleft2.SetActive (true);
			elbow3left.SetActive (false);
			elbowright1.SetActive (false);
			elbowright2.SetActive (true);
			elbow3right.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("WristShoulder") == 3) {
			wrist1left.SetActive (false);
			wrist2left.SetActive (false);
			wrist3left.SetActive (true);
			shoulder1left.SetActive (false);
			shoulder2left.SetActive (false);
			shoulder3left.SetActive (true);
			wrist1right.SetActive (false);
			wrist2right.SetActive (false);
			wrist3right.SetActive (true);
			shoulder1right.SetActive (false);
			shoulder2right.SetActive (false);
			shoulder3right.SetActive (true);
			elbowleft1.SetActive (false);
			elbowlleft2.SetActive (false);
			elbow3left.SetActive (true);
			elbowright1.SetActive (false);
			elbowright2.SetActive (false);
			elbow3right.SetActive (true);
		}
	}

	[SerializeField]
	GameObject hood3;

	[SerializeField]
	GameObject torso3;

	public void LeftTorso () {
		PlayerPrefs.SetInt ("Torso", 1);
		torso1.SetActive (true);
		torso2.SetActive (false);
		torso3.SetActive (false);

	}
	public void RigtTorso () {
		PlayerPrefs.SetInt ("Torso", 2);
		torso1.SetActive (false);
		torso2.SetActive (true);
		torso3.SetActive (false);

	}

	public void RigtTorso2 () {
		PlayerPrefs.SetInt ("Torso", 3);
		torso3.SetActive (true);
		torso2.SetActive (false);
		torso1.SetActive (false);

	}	

	public void LeftTorso2 () {
		PlayerPrefs.SetInt ("Torso", 2);
		torso3.SetActive (false);
		torso2.SetActive (true);
		torso1.SetActive (false);

	}

	public void LeftHead () {
		PlayerPrefs.SetInt ("Head", 1);
		head1.SetActive (true);
		head2.SetActive (false);
	}

	public void RigtHead () {
		PlayerPrefs.SetInt ("Head", 2);
		head1.SetActive (false);
		head2.SetActive (true);
	}


	public void LeftHood () {
		PlayerPrefs.SetInt ("Hood", 1);
		hood1.SetActive (true);
		hood2.SetActive (false);
		hood3.SetActive (false);

	}

	public void RigtHood () {
		PlayerPrefs.SetInt ("Hood", 2);
		hood1.SetActive (false);
		hood2.SetActive (true);
		hood3.SetActive (false);
	}

	public void RigtHood2 () {
		PlayerPrefs.SetInt ("Hood", 3);
		hood3.SetActive (true);
		hood2.SetActive (false);
		hood1.SetActive (false);
	}	

	public void LeftHood2 () {
		PlayerPrefs.SetInt ("Hood", 2);
		hood3.SetActive (false);
		hood2.SetActive (true);
		hood1.SetActive (false);
	}



	[SerializeField]
	GameObject pelvis3;

	public void LeftPelvis () {
		PlayerPrefs.SetInt ("Pelvis", 1);
		pelvis1.SetActive (true);
		pelvis2.SetActive (false);
	}

	public void RigtPelvis () {
		PlayerPrefs.SetInt ("Pelvis", 2);
		pelvis1.SetActive (false);
		pelvis2.SetActive (true);
	}

	public void LeftPelvis2 () {
		PlayerPrefs.SetInt ("Pelvis", 2);
		pelvis1.SetActive (false);
		pelvis2.SetActive (true);
		pelvis3.SetActive (false);
	}

	public void RigtPelvis2 () {
		PlayerPrefs.SetInt ("Pelvis", 3);
		pelvis1.SetActive (false);
		pelvis2.SetActive (false);
		pelvis3.SetActive (true);
	}



	public void Leftwristshoulder () {
		PlayerPrefs.SetInt ("WristShoulder", 1);
		wrist1left.SetActive (true);
		wrist2left.SetActive (false);
		shoulder1left.SetActive (true);
		shoulder2left.SetActive (false);
		wrist1right.SetActive (true);
		wrist2right.SetActive (false);
		shoulder1right.SetActive (true);
		shoulder2right.SetActive (false);
		elbowleft1.SetActive (true);
		elbowlleft2.SetActive (false);
		elbowright1.SetActive (true);
		elbowright2.SetActive (false);
	}

	public void Rigtwristshoulder () {
		PlayerPrefs.SetInt ("WristShoulder", 2);
		wrist1left.SetActive (false);
		wrist2left.SetActive (true);
		shoulder1left.SetActive (false);
		shoulder2left.SetActive (true);
		wrist1right.SetActive (false);
		wrist2right.SetActive (true);
		shoulder1right.SetActive (false);
		shoulder2right.SetActive (true);
		elbowleft1.SetActive (false);
		elbowlleft2.SetActive (true);
		elbowright1.SetActive (false);
		elbowright2.SetActive (true);
	}

	public void Leftwristshoulder2 () {
		PlayerPrefs.SetInt ("WristShoulder", 2);
		wrist1left.SetActive (false);
		wrist2left.SetActive (true);
		wrist3left.SetActive (false);
		shoulder1left.SetActive (false);
		shoulder2left.SetActive (true);
		shoulder3left.SetActive (false);
		wrist1right.SetActive (false);
		wrist2right.SetActive (true);
		wrist3right.SetActive (false);
		shoulder1right.SetActive (false);
		shoulder2right.SetActive (true);
		shoulder3right.SetActive (false);
		elbowleft1.SetActive (false);
		elbowlleft2.SetActive (true);
		elbow3left.SetActive (false);
		elbowright1.SetActive (false);
		elbowright2.SetActive (true);
		elbow3right.SetActive (false);
	}

	public void Rigtwristshoulder2 () {
		PlayerPrefs.SetInt ("WristShoulder", 3);
		wrist1left.SetActive (false);
		wrist2left.SetActive (false);
		wrist3left.SetActive (true);
		shoulder1left.SetActive (false);
		shoulder2left.SetActive (false);
		shoulder3left.SetActive (true);
		wrist1right.SetActive (false);
		wrist2right.SetActive (false);
		wrist3right.SetActive (true);
		shoulder1right.SetActive (false);
		shoulder2right.SetActive (false);
		shoulder3right.SetActive (true);
		elbowleft1.SetActive (false);
		elbowlleft2.SetActive (false);
		elbow3left.SetActive (true);
		elbowright1.SetActive (false);
		elbowright2.SetActive (false);
		elbow3right.SetActive (true);
	}
}
