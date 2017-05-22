using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

    public Transform target;

    Vector3 distanceFromTarget;

	// Use this for initialization
	void Start () {
        distanceFromTarget = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = target.position + distanceFromTarget;
	}
}
