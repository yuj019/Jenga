using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {

	public Transform singleBlock;

	void Start() {
		for (int y = 0; y < 50; y++) {
			for (int x = 0; x < 3; x++) {
				for (int z = 0; z < 3; z++) {
					Instantiate (singleBlock, new Vector3 (x, y, z), Quaternion.identity);
				}
			}
		}
	}
}
