using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 A = new;
        Vector3(target.position.x, target.position.y, target.position.z);
        transform.position = target.position;
        
	}
}
