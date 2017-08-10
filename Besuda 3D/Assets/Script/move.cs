using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public Transform target;
    public float x, z;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 0.1f, 0f, z);
            x = x - 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 0.1f, 0f, z);
            x = x + 0.1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(x, 0f,transform.position.z + 0.1f);
            z = z + 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(x, 0f,transform.position.z - 0.1f);
            z = z - 0.1f;
        }
    }
}
