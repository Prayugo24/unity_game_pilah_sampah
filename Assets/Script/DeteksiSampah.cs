using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*Untuk Penggunaan Komponen UI, harus menambahkan 
 * Library UnityEngine.UI.*/

public class DeteksiSampah : MonoBehaviour {
	/*Digunakan untuk menyimpan string namaTag yang 
	 * nanti akan digunakan untuk filter gameobject 
	 * apa saja yang akan di proses.*/
	public string nameTag;
	/*Digunakan untuk menyimpan resources audio yang 
	 * nanti diperoleh dari file audio yang terdapat 
	 * di Panel Project.*/
	public AudioClip audioBenar;
	public AudioClip audioSalah;

	/*Digunakan untuk control audio baik itu untuk play, 
	 * loop, pause dan stop*/
	private AudioSource MediaPlayerBenar;
	private AudioSource MediaPlayerSAlah;

	/*Digunakan untuk menampilkan score yang telah didapat 
	 * dan pastikan sudah menambah library using UnityEngine.UI;*/
	public Text textScore;
	// Use this for initialization
	void Start () {
		/*Digunakan untuk mendeklarasikan audio pada Control Audio 
		 * supaya dapat dimodifikasi.*/
		MediaPlayerBenar = gameObject.AddComponent<AudioSource> ();
		MediaPlayerBenar.clip=audioBenar;

		MediaPlayerSAlah = gameObject.AddComponent<AudioSource> ();
		MediaPlayerSAlah.clip=audioSalah;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D collision) {
		/*Jika tag object yang masuk ke area Trigger adalah sesuai 
		 * dengan namaTag, maka score akan dihitung dan score akan 
		 * ditampilkan ke textScore. setelah itu object tersebut 
		 * di-destroy dan audio untuk benar dijalankan.*/
		if (collision.tag.Equals (nameTag)) {
			Data.score += 25;
			textScore.text = Data.score.ToString ();
			Destroy (collision.gameObject);
			MediaPlayerBenar.Play ();
		} 
		/*Jika tag object yang masuk ke area Trigger adalah tidak sesuai 
		 * dengan namaTag, maka score akan dikurangi dan score akan 
		 * ditampilkan ke textScore. setelah itu object tersebut 
		 * di-destroy dan audio untuk salah dijalankan*/
		else {
			Data.score -= 5;
			textScore.text = Data.score.ToString ();
			Destroy (collision.gameObject);
			MediaPlayerSAlah.Play ();
		}
	}
}
