using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelCube : MonoBehaviour {

	// START
	void Start () {
		for(int i = 0; i < 10; i++) {
			for(int j = 0; j < 10; j++){
				for (int k = 0; k < 10; k++) {
					VoxelTools.MakeCube (i, j, k);
				}
			}
		}
	}




}