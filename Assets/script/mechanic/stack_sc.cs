using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class stack_sc : MonoBehaviour
{
   public int count;
   public float speed1=5f;
   public bool dokuns,exit;
   public GameObject questpanel,player,carprefab,trenprefab,metalprefab,gecispanel;


   void Start(){

   // trenprefab.SetActive(false);
   }
    void Update()
    {
      
          textyaz();
    }

    public void textyaz(){
      if(count>0){
        var count_text=GameObject.Find("count_text").GetComponent<TextMeshPro>();
          count_text.text=count.ToString();
      }
      
    }
     public void OnTriggerEnter(Collider other){
       if(other.gameObject.tag=="birak"&&this.gameObject.tag=="man"){    
    
        while ( this.gameObject.GetComponent<collectmetal>().metal.Count!=0){
                 var control=GameObject.Find("Quad").GetComponent<controlsc>();
            control.mancalistir();
                StartCoroutine(birak());
                  var metaltext=GameObject.Find("man").GetComponent<TextMeshProUGUI>();
         metaltext.text=this.gameObject.GetComponent<collectmetal>().sayi.ToString(); 
                mancontrol();
            }
          }
            if(other.gameObject.tag=="birak"&&this.gameObject.tag=="car"){
         while (this.gameObject.GetComponent<collectmetal>().metal.Count!=0){
                StartCoroutine(birak());
                     var metaltext=GameObject.Find("car").GetComponent<TextMeshProUGUI>();
         metaltext.text=this.gameObject.GetComponent<collectmetal>().sayi.ToString(); 
                carcontrol();
        
            }
          }
        
          if(other.gameObject.tag=="birak"&&this.gameObject.tag=="tren"){
            
           while(this.gameObject.GetComponent<collectmetal>().metal.Count!=0){
             StartCoroutine(birak());
                     var metaltext=GameObject.Find("tren").GetComponent<TextMeshProUGUI>();
         metaltext.text=this.gameObject.GetComponent<collectmetal>().sayi.ToString(); 
                trencontrol();
                var tren_text=GameObject.Find("trentext").GetComponent<TextMeshPro>();
        tren_text.text=count.ToString();
               speed1=3f;

           }

          }       
 }   
 public void OnTriggerStay(Collider other){
      if(other.gameObject.tag=="state"&&this.gameObject.tag=="tren") speed1=3f; 
      else speed1=10f;
 }
 IEnumerator birak(){          
            Destroy(this.gameObject.GetComponent<collectmetal>().metal[0]);
          this.gameObject.GetComponent<collectmetal>().metal.RemoveAt(0);      
        this.gameObject.GetComponent<collectmetal>().sayi-=1;  count+=1; 
        this.gameObject.GetComponent<collectmetal>().sayi=0;                    
        yield return new WaitForSeconds(2);
    }
    public void mancontrol(){
        if(count>=10)
        {    
          questpanel.SetActive(true);
        player.GetComponent<movement>().enabled=false;
        player.GetComponent<Animator>().enabled=false;
        new WaitForSeconds(2f);
        instantiate(); player.SetActive(false); 
        var control=GameObject.Find("Quad").GetComponent<controlsc>();
        control.carcalistir();   
         var text=GameObject.Find("manager").GetComponent<controlmanager>();
        text.man.SetActive(false);
        text.car.SetActive(true);
       // count=0;
       
        }
   }        
       public void carcontrol(){
               if(count>=50)
        {    
        //  player.SetActive(false);
      //   trenprefab.SetActive(true);
         var prefab=GameObject.Find("manager").GetComponent<controlmanager>();
          prefab.trenprefab1.SetActive(true);         
        var control=GameObject.Find("Quad").GetComponent<controlsc>();
         control.trencalistir();      
         var cam=GameObject.Find("Camera");
         cam.SetActive(false);
        var trentakip=GameObject.Find("Follower");       
         trentakip.SetActive(true);
         var text=GameObject.Find("manager").GetComponent<controlmanager>();
         text.car.SetActive(false); 
         text.tren.SetActive(true);
         carprefab.SetActive(false);
         count=0;
        }
         }
         public void trencontrol(){
          if(count>=100){
         new WaitForSeconds(2f);
         var end=GameObject.Find("manager").GetComponent<controlmanager>();
         end.endgamepanel.SetActive(true);       
         count=0;
         }
         }        
   public void cıkıs(){
        GameObject.Find("quest_panel").SetActive(false);
        player.GetComponent<movement>().enabled=true;
        player.GetComponent<Animator>().enabled=true; 
        this.gameObject.GetComponent<collectmetal>().sayi=0;
    }

    public void instantiate(){

      Vector3 hedef=new Vector3(player.transform.position.x,player.transform.position.y,player.transform.position.z);
     carprefab= Instantiate(carprefab,hedef,Quaternion.identity);
    var cam=GameObject.Find("Camera").GetComponent<camerafollow>();
      cam.hedef=carprefab;
    }



}
