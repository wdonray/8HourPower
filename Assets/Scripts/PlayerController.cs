using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text Pos_Text;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Pos_Text.text = rb.transform.position.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        Pos_Text.text = rb.transform.position.ToString();
    }
    void FixedUpdate()
    {
        float moveHor = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHor, 0.0f, moveVert);

        rb.AddForce(movement * speed);
    }
}
