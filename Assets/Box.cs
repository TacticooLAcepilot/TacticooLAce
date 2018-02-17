using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    float rotationX;
    float rotationY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotationX += Time.deltaTime * 100;
        rotationY += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
	}
}
