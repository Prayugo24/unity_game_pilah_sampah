using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindah : MonoBehaviour {
	//Menyimpan nilai pecahan yang digunakan untuk menentukan kecepatan dengan nilai awal 3
	float speed=3f;
	//Menyimpan nilai array tunggal yang nantinya digunakan untuk menyimpan Gambar yang berupa sprite.
	public Sprite[] sprites;
	// Use this for initialization
	//Method ini hanya sekali dijalankan ketika pertama kali dijalankan.
	void Start () {
		//untuk random sprites
		//Memberi nilai Acak dengan batasan maksimal sejumlah array Sprite yang dimasukkan.
		int index = Random.Range (0, sprites.Length);
		gameObject.GetComponent<SpriteRenderer> ().sprite = sprites [index];
	}
	
	// Update is called once per frame
	void Update () {
		//agar sprites bergerak 
		//Menghitung pergerakkan ke kiri berikutnya pada suatu object berdasarkan sumbu X
		float move= (speed*Time.deltaTime* -1f)+transform.position.x;
		//Mengimplementasikan pergerakkan secara horizontal pada Gameobject.
		transform.position=new Vector3(move,transform.position.y);
		
	}
	/*private digunakan ketika variable tersebut hanya digunakan pada Class tersebut, 
	Vector3 digunakan untuk menyimpan 3 nilai berupa X, Y dan Z. ScreenPoint digunakan untuk menyimpan nilai posisi object terhadap screen.*/
	private Vector3 ScreenPoint;

	//variable ini digunakan untuk menyimpan selisih posisi object dengan posisi mouse
	private Vector3 offset;
	// variable ini digunakan untuk menyimpan posisi vertikal awal yang nantinya digunakan untuk mengembalikan ke posisi semula 
	private float firstY;

	/*Method ini dijalankan ketika mouse/ touch klik  pada sebuah Gameobject memiliki Collider. 
	 * Method ini hanya sekali dijalankan ketika ada action dari mouse/touch. Method ini menjalankan 
	 * code yang berfungsi untuk  melakukan inisialisasi terhadap Gameobject dan mouse yang nanti nilai 
	 * tersebut akan digunakan untuk menggeser Gameobject tersebut.*/
	void OnMouseDown(){
		firstY = transform.position.y;
		ScreenPoint = Camera.main.WorldToScreenPoint (gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z));
	}

	/*Method ini dijalankan ketika mouse/ touch klik dan tahan  pada sebuah 
	 * Gameobject memiliki Collider. Method ini terus dijalankan sampai melepaskan 
	 * untuk klik Gameobject tersebut. Method ini menjalankan code yang berfungsi 
	 * untuk  melakukan pemindahan posisi Gameobject berdasarkan posisi mouse.*/
	void OnMouseDrag(){
		Vector3 curScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, ScreenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;
	}
	/*Method ini dijalankan ketika mouse/ touch melepaskan klik  pada sebuah Gameobject 
	 * memiliki Collider. Method ini hanya sekali dijalankan ketika mouse/touch melepaskan  
	 * klik terhadap Gameobject tersebut. Method ini menjalankan code yang berfungsi untuk  
	 * mengembalikan posisi pada Gameobject ke posisi awal.*/
	private void OnMouseUp(){
		transform.position = new Vector3 (transform.position.x, firstY, transform.position.z);
	}
}
