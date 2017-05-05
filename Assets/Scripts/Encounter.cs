using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Encounter : MonoBehaviour
{
    public Text Health_Text, Spawner_Count, Win_Text;
    public AudioSource Pick_Up;
    public AudioClip Sound;

    private int Counter;
    private int Player_Health;
    private void Start()
    {
        Counter = 3;
        Pick_Up.clip = Sound;
        Win_Text.text = "";
        Spawner_Count.text = "Spawners left to collect: " + Counter;
        Player_Health = this.gameObject.GetComponent<PlayerClass>().Health;
        Health_Text.text = "Health: " + Player_Health;
    }
    private void Update()
    {
        if (Counter == 0)
        {
            StartCoroutine(Load(4, "Menu"));
            Win_Text.text = "YOU WON \n \nRestarting";
        }
        else if (Player_Health == 0)
        {
            StartCoroutine(Load(4, "Menu"));
            Win_Text.text = "YOU LOST \n \nRestarting";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Spawner"))
        {
            other.gameObject.SetActive(false);
            Pick_Up.Play();
            Counter -=1;
            Spawner_Count.text = "Spawners left to collect: " + Counter;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            if (Player_Health > 0)
            {
                Player_Health -= 1;
                Health_Text.text = "Health: " + Player_Health;
            }
        }
    }
    IEnumerator Load(int Delay, string Load)
    {
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene(Load);
    }
}


