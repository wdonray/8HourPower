using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerClass : MonoBehaviour {
    public int Health;
	// Use this for initialization
	void Start () {
        Health = 10;
	}
	// Update is called once per frame
	void Update () {
        //Health_Text.text = "Health: " + Health;
    }
}
