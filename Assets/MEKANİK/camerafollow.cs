using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject hedef;
    public int ypos;
   public Vector3 mesafe;
 public float cameraDistance = 10.0f;
   private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float chaseSpeed = 5;
    void LateUpdate()
    {  
      // transform.position=hedef.transform.position-hedef.transform.forward*mesafe_;
     //  transform.LookAt(hedef.transform.position);
      // transform.position=new Vector3(transform.position.x,transform.position.y+height,transform.position.z);
        this.transform.position=Vector3.Lerp( this.transform.position , hedef.transform.position + mesafe , chaseSpeed*Time.deltaTime);
        //this.transform.LookAt(hedef.transform); 
   
    
       //transform.position = hedef.transform.position - hedef.transform.forward * cameraDistance;
        //transform.LookAt (hedef.transform.position);
        //transform.position = new Vector3 (transform.position.x, transform.position.y + ypos, transform.position.z);
    

    }
  
}

