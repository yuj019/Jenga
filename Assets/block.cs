using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	public Transform singleBlock;
	void Start() {
		for (int y = 0; y < 50; y++) {
			float pos = -.25f;
			Quaternion rot = Quaternion.identity;
			for (int x = 0; x < 3; x++) {
				if (y % 2 == 0) {
					rot = Quaternion.identity;
					Instantiate (singleBlock, new Vector3 (0,(.18f*y),pos), rot);
				} else {
					rot.eulerAngles = new Vector3 (0, 90, 0);
					Instantiate (singleBlock, new Vector3 (pos,(.18f*y),0), rot);
				}
				pos += .25f;
			}
		}
	}
}
