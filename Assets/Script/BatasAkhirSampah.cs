using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Untuk memanggil method SceneManager.LoadScene(), harus terdapat library UnityEngine.SceneManagement*/
public class BatasAkhirSampah : MonoBehaviour {
	/*Method ini dijalankan ketika ada sebuah object yang masuk ke area Trigger.*/
	private void OnTriggerEnter2D(Collider2D collision)
	{
		/*Kemudian menghapus gameobject tersebut*/
		Destroy(collision.gameObject);
		/*membuka scene "Gameobject" (Scene "Gameover" baru dapat ditampilkan ketika Scene tersebut sudah terdaftar di Scene in Build)*/
		SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
