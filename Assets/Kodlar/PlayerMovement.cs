using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float horizontal=0;
    float vertical=0;
    Vector3 vec;
    public float speed;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float fireTime;
    public float fireTimeLeft;
    public GameObject bullet;
    public Transform bulletLeft;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal, 0, vertical);
        rb.velocity = vec * speed;

        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, minX, maxX),
            0.0f,
            Mathf.Clamp(rb.position.z, minZ, maxZ)
        );
        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x);
       
    }

     void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time > fireTime)
        {
            fireTime = Time.time + fireTimeLeft;
            Instantiate(bullet, bulletLeft.position, Quaternion.FromToRotation(Vector3.up, transform.forward));

        }
        
        }
    }





