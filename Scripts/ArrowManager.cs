using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {
	[SerializeField]
	GameObject righttorsoarrow,righttorsoarrow2,lefttorsoarrow,lefttorsoarrow2,righthoodarrow,righthoodarrow2,lefthoodarrow,lefthoodarrow2;

	void Start () {
		if (PlayerPrefs.GetInt ("Torso") == 2) {
			righttorsoarrow.SetActive (false);
			righttorsoarrow2.SetActive (true);
			lefttorsoarrow.SetActive (true);
			lefttorsoarrow2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Torso") == 3) {
			righttorsoarrow.SetActive (false);
			righttorsoarrow2.SetActive (true);
			lefttorsoarrow.SetActive (false);
			lefttorsoarrow2.SetActive (true);
		}
		if (PlayerPrefs.GetInt ("Hood") == 2) {
			righthoodarrow.SetActive (false);
			righthoodarrow2.SetActive (true);
			lefthoodarrow.SetActive (true);
			lefthoodarrow2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Hood") == 3) {

			righthoodarrow.SetActive (false);
			righthoodarrow2.SetActive (true);
			lefthoodarrow.SetActive (false);
			lefthoodarrow2.SetActive (true);
		}

		if (PlayerPrefs.GetInt ("Pelvis") == 2) {
			rightpelvisarrow.SetActive (true);
			rightpelvisarrow2.SetActive (true);
			leftpelvisarrow.SetActive (true);
			leftpelvisarrow2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("Pelvis") == 3) {
			rightpelvisarrow.SetActive (false);
			rightpelvisarrow2.SetActive (true);
			leftpelvisarrow.SetActive (false);
			leftpelvisarrow2.SetActive (true);
		}

		if (PlayerPrefs.GetInt ("WristShoulder") == 2) {
			rightWristShoulder.SetActive (false);
			rightWristShoulder2.SetActive (true);
			leftWristShoulder.SetActive (true);
			leftWristShoulder2.SetActive (false);
		}
		if (PlayerPrefs.GetInt ("WristShoulder") == 3) {
			rightWristShoulder.SetActive (false);
			rightWristShoulder2.SetActive (true);
			leftWristShoulder.SetActive (false);
			leftWristShoulder2.SetActive (true);
		}


	}
	

	public void LeftTorsoArrow () {
		righttorsoarrow.SetActive (true);
		righttorsoarrow2.SetActive (false);
	}

	public void RightTorsoArrow(){
		righttorsoarrow.SetActive (false);
		righttorsoarrow2.SetActive (true);
	}

	public void LeftTorsoArrow2 () {
		//righttorsoarrow.SetActive (true);
		//righttorsoarrow2.SetActive (false);
		lefttorsoarrow.SetActive (true);
		lefttorsoarrow2.SetActive (false);
	}

	public void RightTorsoArrow2(){
		righttorsoarrow.SetActive (false);
		righttorsoarrow2.SetActive (true);
		lefttorsoarrow.SetActive (false);
		lefttorsoarrow2.SetActive (true);
	}


	public void LeftHoodArrow () {
		righthoodarrow.SetActive (true);
		righthoodarrow2.SetActive (false);
	}
	public void RightHoodArrow () {
		righthoodarrow.SetActive (false);
		righthoodarrow2.SetActive (true);
	}

	public void LeftHoodArrow2 () {
		//righthoodarrow.SetActive (true);
		//righthoodarrow2.SetActive (false);
		lefthoodarrow.SetActive (true);
		lefthoodarrow2.SetActive (false);
	}
	public void RightHoodArrow2 () {
		righthoodarrow.SetActive (false);
		righthoodarrow2.SetActive (true);
		lefthoodarrow.SetActive (false);
		lefthoodarrow2.SetActive (true);
	}

	[SerializeField]
	GameObject rightpelvisarrow,rightpelvisarrow2,leftpelvisarrow,leftpelvisarrow2;

	public void LeftPelvisArrow () {
		rightpelvisarrow.SetActive (true);
		rightpelvisarrow2.SetActive (false);
	}
	public void RightPelvisArrow () {
		rightpelvisarrow.SetActive (false);
		rightpelvisarrow2.SetActive (true);
	}

	public void LeftPelvisArrow2 () {
		//rightpelvisarrow.SetActive (true);
		//rightpelvisarrow2.SetActive (false);
		leftpelvisarrow.SetActive (true);
		leftpelvisarrow2.SetActive (false);
	}
	public void RightPelvisArrow2 () {
		rightpelvisarrow.SetActive (false);
		rightpelvisarrow2.SetActive (true);
		leftpelvisarrow.SetActive (false);
		leftpelvisarrow2.SetActive (true);
	}

	[SerializeField]

	private GameObject rightWristShoulder,leftWristShoulder,rightWristShoulder2,leftWristShoulder2;

	public void LeftWristShoulder () {
		rightWristShoulder.SetActive (true);
		rightWristShoulder2.SetActive (false);
	}

	public void RightWristShoulder(){
		rightWristShoulder.SetActive (false);
		rightWristShoulder2.SetActive (true);
	}

	public void LeftWristShoulder2 () {
		//rightWristShoulder.SetActive (true);
		//rightWristShoulder2.SetActive (false);
		leftWristShoulder.SetActive (true);
		leftWristShoulder2.SetActive (false);
	}

	public void RightWristShoulder2(){
		rightWristShoulder.SetActive (false);
		rightWristShoulder2.SetActive (true);
		leftWristShoulder.SetActive (false);
		leftWristShoulder2.SetActive (true);
	}

}
