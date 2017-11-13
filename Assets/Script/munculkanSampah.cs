using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculkanSampah : MonoBehaviour {

	//Digunakan untuk menyimpan nilai jeda untuk berapa 
	//lama object sampah akan dimunculkan.
	public float jeda =0.8f;
	//Digunakan untuk menyimpan waktu
	float timer;
	// Use this for initialization
	//Digunakan untuk menyimpan object sampah yang nanti akan ditampilkan
	public GameObject[] obyekSampah;
	void Start () {
		
	}
	
	// Update is called once per frame
	/*Method ini akan terus dijalankan dengan kecepatan berdasarkan 
		 * kecepatan prosessor yang dimiliki device.*/
	void Update () {
		/*Code ini akan memproses berdasarkan waktu jeda yang telah ditentukan*/
		timer += Time.deltaTime;
		if (timer > jeda) {
			/*Code ini menentukan index object sampah secara acak yang akan dimunculkan*/
			int random = Random.Range (0, obyekSampah.Length);
			/*Code ini untuk memunculkan object Sampah dari index
			 *yang telah ditentukan sebelumnya dengan posisi dan rotasi Gameoject yang terdapat Script ini.*/
			Instantiate (obyekSampah [random], transform.position, transform.rotation);

			/*Setelah selesai menjalankan code diatas, kemudian timer dikembalikan ke 0 untuk menghitung nilai 
		 * jeda dari awal. */
			timer = 0;
		}


	}

}
