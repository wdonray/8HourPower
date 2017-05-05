using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekTarget : MonoBehaviour
{
    private Transform target;
    public int max_vel;

    private Vector3 velocity, force, displacement, scale_displacment, new_force;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        velocity = Vector3.zero;
        force = Vector3.zero;
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public float distOffset = 1f;
    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, target.position, Color.blue);
        displacement = target.position - transform.position;
        scale_displacment = displacement.normalized * max_vel;
        velocity += (scale_displacment * Time.deltaTime);
        if (velocity.magnitude > max_vel)
            velocity = velocity.normalized * max_vel;
        bool tooclose = Vector3.Distance(target.localPosition, transform.localPosition) < distOffset;
        if (tooclose)
            return;
        rb.AddForce(velocity.normalized * max_vel);
    }
}
