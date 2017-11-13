using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	float timer =0;
	
	// Update is called once per frame
	void Update () {
		/*Saat masuk ke tampilan Gameover, ketika waktu 
		 * lebih dari 2 detik, maka game akan reset seperti 
		 * semua dan kembali ke Tampilan gameplay. Penggunaan 
		 * MethodSceneManager.LoadScene() harus memasukkan 
		 * library using UnityEngine.SceneManagement;*/
		timer += Time.deltaTime;
		if (timer>2){
			Data.score = 0;
			SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);
		}
	}
}
