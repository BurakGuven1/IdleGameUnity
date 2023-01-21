using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class manager : MonoBehaviour
{

    public GameObject canvas1,canvas2;
    void Start()
    {
        canvas2.SetActive(false);
      
    }

   public void kapa(){

       canvas1.SetActive(false);
       canvas2.SetActive(true);


   }
   public void aç(){

       canvas1.SetActive(false);

       canvas2.SetActive(true);

   }
   public void gamescreen(){

    SceneManager.LoadScene("gamescene");



   }
   



}
