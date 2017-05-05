using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Cat_Prefab;
    public int Spawn_After;

    private GameObject Spawn;
    private float time;
    // Use this for initialization
    void Start()
    {
        Spawn = gameObject;
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject Cat;
        if (time >= Spawn_After)
        {
            Cat = Instantiate(Cat_Prefab, Spawn.transform.position, Quaternion.identity) as GameObject;
            time = 0.0f;
        }
        time += Time.deltaTime;
    }
}
