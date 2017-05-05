using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject The_Player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - The_Player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = The_Player.transform.position + offset;
	}
}
