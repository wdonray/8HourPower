using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);	
	}
}
