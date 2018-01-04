using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuController : MonoBehaviour {
	[SerializeField]
	private Animator anim;

	[SerializeField]
	public GameObject Panel2;

	[SerializeField]
	public AudioSource music;

	void Start(){
		
		if (GameObject.FindGameObjectsWithTag ("Music").Length >= 2) {
			GameObject[] musics = GameObject.FindGameObjectsWithTag ("Music");
			GameObject.Destroy (musics [0]);
			//foreach (GameObject musicss in musics)
				//GameObject.Destroy (musicss);
		}
		
	}

	public void MainMenu(){
		SceneManager.LoadScene ("Menu");
	}

	public void Level1(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level1");
	}

	public void Level2(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level2");
	}

	public void Level3(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level3");
	}

	public void Level4(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level4");
	}

	public void Level5(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level5");
	}

	public void Level6(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level6");
	}

	public void Level7(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level7");
	}
	public void Level8(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level8");
	}
	public void Level9(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level9");
	}
	public void Level10(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level10");
	}
	public void Level11(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level11");
	}
	public void Level12(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level12");
	}
	public void Level13(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level13");
	}
	public void Level14(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level14");
	}
	public void Level15(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level15");
	}

	public void Level16(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level16");
	}

	public void Level17(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level17");
	}

	public void Level18(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level18");
	}
	public void Level19(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level19");
	}
	public void Level20(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level20");
	}
	public void Level21(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level21");
	}
	public void Level22(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level22");
	}
	public void Level23(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level23");
	}
	public void Level24(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level24");
	}
	public void Level25(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level25");
	}
	public void Level26(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level26");
	}
	public void Level27(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level27");
	}
	public void Level28(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level28");
	}
	public void Level29(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level29");
	}
	public void Level30(){
		DontDestroyOnLoad (music);
		SceneManager.LoadScene ("Level30");
	}



	public void LevelAnim(){
		Panel2.SetActive (true);
		anim.SetInteger ("LevelAnim", 1);
	}
	public void LevelAnimTers(){
		anim.SetInteger ("LevelAnim", 2);
		StartCoroutine (Panel2False ());
	}

	IEnumerator Panel2False(){
		yield return new WaitForSeconds (0.4f);
		Panel2.SetActive (false);
	}

}
