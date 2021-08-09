using UnityEngine;
using System.Collections;

public class Asteroid : MonoBehaviour
{
   
    public float tumble;
   
    public Rigidbody rb;
    public float hız;

    GameObject GameControl;
    GameControl control;

    void Start()
    {
        GameControl = GameObject.FindWithTag("gamecontrol");
        control = GameControl.GetComponent<GameControl>();



        rb.velocity = transform.forward * hız;
        rb.GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sınır")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            
        }

    }

}