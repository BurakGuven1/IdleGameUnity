using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlmanager : MonoBehaviour
{
    public GameObject car,man,tren,carprefab1,trenprefab1;
    public stack_sc stack;
    public GameObject panel,endgamepanel;
     
    void Start()
    {
      fonk();  
      man.SetActive(true); 
        car.SetActive(false); 
      tren.SetActive(false);
    }

    void Update()
    {
      
    }   
   public void endbutton(){
      SceneManager.LoadScene("SampleScene");
   }
   public void fonk(){
    panel.SetActive(true);
      var player1=GameObject.FindWithTag("Player");
     player1.GetComponent<movement>().enabled=false;
      new WaitForSeconds(3f);
    
   } 
   public void girispanelkapa(){
      panel.SetActive(false);
      var player1=GameObject.FindWithTag("Player");
   player1.GetComponent<movement>().enabled=true;

   }
   public void fonksiyon(){
    //       if(stack.count==10)
    //  {
     
    //  man.SetActive(false); 
    //    car.SetActive(true);
    //  }  
      // if(stack.count>=50){
      //  car.SetActive(false);
      // tren.SetActive(true);
      // }
  
   }
}
