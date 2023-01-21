using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonemetal : MonoBehaviour
{
  public GameObject metalprefab;
  public List<GameObject> metalist=new List<GameObject>();  
  public List<GameObject> metalist2;
  public List<GameObject> trainmetal;


  void Start(){
          StartCoroutine(klonla()); 
         StartCoroutine(klonla2());
         StartCoroutine(allclone());
         StartCoroutine(trainclone());

  }
    void Update()
    {
      
          if (metalist.Count<=7)
      {
         StartCoroutine(klonla()); 
         StartCoroutine(klonla2());
      }
      if(metalist2.Count<=8){
         StartCoroutine(allclone());

      }
    if(trainmetal.Count<=8){
      StartCoroutine(trainclone());
    }
       
    }
  public IEnumerator klonla(){     
       
       for (int i = 0; i < 3; i++)
       {
        Vector3 poz= new Vector3(Random.Range(692f,698f),1480.35f,Random.Range(-4.33f,10.79f) );
        var listprefab=Instantiate(metalprefab,poz,Quaternion.identity);
       metalist.Add(listprefab);   
       listprefab.transform.parent=this.transform;
      
       } 
          yield return new WaitForSeconds(2f);

    }
    public IEnumerator klonla2(){
       for (int i = 0; i < 3; i++)
       {
        Vector3 poz= new Vector3(Random.Range(746f,754f),1480.35f,Random.Range(-4.33f,10.79f) );
        var listprefab=Instantiate(metalprefab,poz,Quaternion.identity);
       metalist.Add(listprefab);   
       listprefab.transform.parent=this.transform;
      
       } 
          yield return new WaitForSeconds(2f);

    }
    public IEnumerator allclone(){
     
      for (int i = 0; i < 7; i++)
      {
          Vector3 poz= new Vector3(Random.Range(672f,787f),1480.35f,Random.Range(-24f,80f) );
        var listprefab=Instantiate(metalprefab,poz,Quaternion.identity);
       metalist2.Add(listprefab);  
       listprefab.transform.parent=this.transform;
      }
      yield return new WaitForSeconds(2f);
    }
    public IEnumerator trainclone(){

      for (int i = 0; i < 7; i++)
      {
          Vector3 poz=new Vector3(Random.Range(760.25f,700.9f),1481.75f,Random.Range(178.676f,179.969f));
          // Vector3 poz2=new Vector3(Random.Range(693.71f,691.56f),1481.50f,Random.Range(129.42f,164.14f));
            Vector3 poz3=new Vector3(Random.Range(771.17f,769.61f),1481.50f,Random.Range(125.38f,167.43f));

            var listprefab2 =Instantiate(metalprefab,poz3,Quaternion.identity);
            trainmetal.Add(listprefab2);
          // var listprefab1=Instantiate(metalprefab,poz2,Quaternion.identity);
          // trainmetal.Add(listprefab1);
        var listprefab =Instantiate(metalprefab,poz,Quaternion.identity);
        trainmetal.Add(listprefab);

        listprefab.transform.parent=this.transform;
        //listprefab1.transform.parent=this.transform;
        listprefab2.transform.parent=this.transform;

      }
      yield return new WaitForSeconds(2f);


    }
}
