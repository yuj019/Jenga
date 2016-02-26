using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class restart : MonoBehaviour {

	//press "esc" to show the pulse panel
	// Update is called once per frame
	void update() {
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("Jenga");
		}
	}
}
