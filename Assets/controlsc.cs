using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlsc : MonoBehaviour
{
    public GameObject manpanel,anapanel,carpanel,cartextpanel,mantext,trentext;

    void Start()
    {
        anapanel.SetActive(false);
        manpanel.SetActive(true);
        carpanel.SetActive(false);
        cartextpanel.SetActive(false);
        trentext.SetActive(false);
    }

    public void mancalistir(){

        manpanel.SetActive(false);
       anapanel.SetActive(true);


    }  
    public void carcalistir(){

        
        mantext.SetActive(false);
        cartextpanel.SetActive(true);
    }  
    public void trencalistir(){
        cartextpanel.SetActive(false); 
       // anapanel.SetActive(false);      
        trentext.SetActive(true);
    }
  
}
