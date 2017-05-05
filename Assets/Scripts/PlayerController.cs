using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (Input.GetKey(KeyCode.A))
            rb.transform.position += Vector3.left * .05f;
        if (Input.GetKey(KeyCode.D))
            rb.transform.position += Vector3.right * .05f;
        if (Input.GetKey(KeyCode.W))
            rb.transform.position += Vector3.forward * .05f;
        if (Input.GetKey(KeyCode.S))
            rb.transform.position += Vector3.back * .05f;
        if (Input.GetKey(KeyCode.Space))
            rb.transform.position += Vector3.up * .1f;
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene("0.main");
        if (Input.GetKeyDown(KeyCode.M))
            SceneManager.LoadScene("Menu");
    }
}