using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collectmetal : MonoBehaviour
{
   
   // public metalcollectable metalcollect;
   metalcollectable metal_sc;
   public bool dokun;
    //carmetaltext,ucakmetaltext,gemimetaltext,trenmetaltext;
    public List<GameObject> metal=new List<GameObject>();
    //public GameObject metalprefab;
    public int sayi;
 
    private int dizisayi;    
    //public AudioSource pickup;
    float yukseklik;
    void Start()
    {
       // anametal=GameObject.Find("anametal");
       
    }
    void Update(){

       // anametal.transform.position=new Vector3(transform.position.x,yukseklik,transform.position.z);
       // this.transform.localPosition=new Vector3(0,yukseklik,0);
   
        dizisayi=metal.Count;
        

         
    }
    public void yuksek(){
        yukseklik++;
    }
 
   public void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="topla"&&other.gameObject.GetComponent<metalcollectable>().GetToplandımi()==false){

        if(metal.Count<=4&&this.gameObject.tag=="man"){                 
                sayi+=1;
                var sc=GameObject.Find("metalclone").GetComponent<clonemetal>();
                sc.metalist.RemoveAt(0); 
                sc.metalist2.RemoveAt(0);   
            var metaltext=GameObject.Find("man").GetComponent<TextMeshProUGUI>();
         metaltext.text=sayi.ToString();            
         other.gameObject.GetComponent<metalcollectable>().toplandıyap();
         other.gameObject.transform.parent=this.transform;  
          metal.Add(other.gameObject);  
          other.transform.position = new Vector3(other.transform.position.x,metal[dizisayi-1].transform.position.y + 0.6f, other.transform.position.z);        
         }
         if(metal.Count<=9&&this.gameObject.tag=="car"){  
            sayi+=1;    
            var sc=GameObject.Find("metalclone").GetComponent<clonemetal>();
                sc.metalist.RemoveAt(0); 
                sc.metalist2.RemoveAt(0);   
           var metaltext=GameObject.Find("car").GetComponent<TextMeshProUGUI>();
         metaltext.text=sayi.ToString();
         other.gameObject.SetActive(false);
         other.gameObject.GetComponent<metalcollectable>().toplandıyap();
         other.gameObject.transform.parent=this.transform;  
                metal.Add(other.gameObject);   
          
                           
      other.transform.position = new Vector3(other.transform.position.x,metal[dizisayi-1].transform.position.y + 0.6f, other.transform.position.z); 
      
            }
                if(metal.Count<=49&&this.gameObject.tag=="tren"){
            dokun=true;
            sayi+=1;
           var sc=GameObject.Find("metalclone").GetComponent<clonemetal>();
            sc.trainmetal.RemoveAt(0);
            var metaltext=GameObject.Find("tren").GetComponent<TextMeshProUGUI>();
            metaltext.text=sayi.ToString();
         // other.gameObject.SetActive(false);
             other.gameObject.GetComponent<metalcollectable>().toplandıyap();
             other.gameObject.transform.parent=this.transform;  
             metal.Add(other.gameObject);  
            other.transform.position = new Vector3(other.transform.position.x,metal[dizisayi-1].transform.position.y + 0.6f, other.transform.position.z); 

            }
         if(metal.Count<=109&&this.gameObject.tag=="ucak"){
               sayi+=1;
              
       // other.gameObject.SetActive(false);
         other.gameObject.GetComponent<metalcollectable>().toplandıyap();
         other.gameObject.transform.parent=this.transform;  
                metal.Add(other.gameObject);                  
      other.transform.position = new Vector3(other.transform.position.x,metal[dizisayi-1].transform.position.y + 0.6f, other.transform.position.z); 

            }
        
         if(metal.Count<=199&&this.gameObject.tag=="gemi"){
               sayi+=1;
              
         //other.gameObject.SetActive(false);
         other.gameObject.GetComponent<metalcollectable>().toplandıyap();
         other.gameObject.transform.parent=this.transform;  
                metal.Add(other.gameObject); 
      other.transform.position = new Vector3(other.transform.position.x,metal[dizisayi-1].transform.position.y + 0.6f, other.transform.position.z); 


            }
         if (yukseklik == 0f)
            {
                yukseklik += 2f;
            }
          
   }
    }

      
   

   }

