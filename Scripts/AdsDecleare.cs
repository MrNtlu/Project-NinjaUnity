using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsDecleare : MonoBehaviour {



	public void AdShower () {
		int RandomNum =Random.Range (0, 100);
		if (RandomNum <= 55) {
			Advertisement.Initialize ("1530333", true);
			StartCoroutine (ShowAdWhenReady ());
		}

	}

	IEnumerator ShowAdWhenReady(){
		while (!Advertisement.IsReady ())
			yield return null;
		Advertisement.Show ();
	}

}


