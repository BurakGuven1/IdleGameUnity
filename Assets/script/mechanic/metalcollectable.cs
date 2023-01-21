using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metalcollectable : MonoBehaviour
{
    public bool toplandımi,toplandı;
    //public GameObject uyarı;
    float index;

    void Start()
    {
        toplandımi=false;
      //  uyarı.SetActive(false);
    }

    void Update()
    {
        if(toplandımi==true){
            if(transform.parent!=null){

           transform.localPosition=new Vector3(0, transform.localPosition.y, 0);
        }
       
        }
        
    }
   

    public bool GetToplandımi(){

        return toplandımi;
    }
    public void toplandıyap(){
        toplandımi=true;
    }
    /*public void indexayarla(float index){
        this.index=index;
    }*/
     
 
}
