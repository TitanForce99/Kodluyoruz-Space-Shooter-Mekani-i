using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blow: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bombBlow;

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sınır")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(bombBlow, transform.position, transform.rotation);
        }

    }

}
