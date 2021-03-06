﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class block : MonoBehaviour {

	public Transform singleBlock;
	public Vector3 torque;
	public Rigidbody rb;
	public InputField input;
	string txt;
	int height = 18;

	//press "esc" to show the pulse panel
	void Start() {
		
		rb = singleBlock.GetComponent<Rigidbody>();
		//set default height to 18
			for (int y = 0; y < height; y++) {
				float pos = .25f;
				Quaternion rot = Quaternion.identity;
				for (int x = 0; x < 3; x++) {
					if (y % 2 == 0) {
						rot = Quaternion.identity;
						Instantiate (singleBlock, new Vector3 (0, (.18f * y), pos), rot);
						transform.localScale = Vector3.one * Random.Range (1, 5);
					} else {
						rot.eulerAngles = new Vector3 (0, 90, 0);
						Instantiate (singleBlock, new Vector3 (pos, (.18f * y), 0), rot);
						transform.localScale = Vector3.one * Random.Range (1, 5);
					}
				}
			}
		if (transform.hasChanged) {
			//let user select height in between 2 and 50
			input = singleBlock.GetComponent<InputField>();
			txt = input.text;
			height = int.Parse (txt);

			if (height > 1 && height < 51) {
				for (int y = 0; y < height; y++) {
					float pos = .25f;
					Quaternion rot = Quaternion.identity;
					for (int x = 0; x < 3; x++) {
						if (y % 2 == 0) {
							rot = Quaternion.identity;
							Instantiate (singleBlock, new Vector3 (0, (.18f * y), pos), rot);
							transform.localScale = Vector3.one * Random.Range (1, 5);
						} else {
							rot.eulerAngles = new Vector3 (0, 90, 0);
							Instantiate (singleBlock, new Vector3 (pos, (.18f * y), 0), rot);
							transform.localScale = Vector3.one * Random.Range (1, 5);
						}
					}
				}
			} else {
				Debug.Log ("Please select a height in between 2 and 50");
			}
		}
	}

	/*void update() {
		if (Input.GetKeyDown(KeyCode.Z))
		{
			GameObject clone = InstantiateRandomScale(prefab, 1, 5);
		}
	}*/
	/*void update() {

		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("Jenga");
		}
	}

	void Awake()
	{
		torque.x = Random.Range (-100, 100);
		torque.y = Random.Range (-100, 100);
		torque.z = Random.Range (-100, 100);
		rb.AddForce(torque);
	}

	/*GameObject InstantiateRandomScale(GameObject source, float minScale, 
		float maxScale)
	{
		GameObject clone = Instantiate(source) as GameObject;
		clone.transform.localScale = Vector3.one * Random.Range(minScale, maxScale);
		return clone;
	}*/


}
