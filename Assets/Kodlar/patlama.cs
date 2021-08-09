using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;
public class patlama: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bombBlow;
   public GameObject playerBoom;
    GameObject GameControl;
     GameControl control;
   
    

    void Start()
    {
        GameControl = GameObject.FindGameObjectWithTag("gamecontrol");
        control = GameControl.GetComponent<GameControl>();
       
    }



     void OnTriggerEnter(Collider col)
    {
       
       if(col.gameObject.tag != "sınır")
        {
            Destroy(col.gameObject); 
           Destroy(gameObject);
              Instantiate(bombBlow, transform.position, transform.rotation);
            control.Scoreİncrease(10);
            
           
          
        }

        if (col.gameObject.tag == "player")
        {
            Instantiate(playerBoom, col.transform.position, col.transform.rotation);
        }



    }

}
