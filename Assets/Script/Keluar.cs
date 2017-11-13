using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		/*Script ini berfungsi ketika keyboard menekan 
		 * escape atau device mobile menekan tombol back 
		 * maka Aplikasi akan keluar.*/
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
