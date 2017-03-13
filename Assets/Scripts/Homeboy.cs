using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homeboy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }
}
