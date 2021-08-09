using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour
{
    private void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);
    }
}
