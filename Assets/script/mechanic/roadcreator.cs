using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadcreator : MonoBehaviour
{
    public List<Transform> obje=new List<Transform>();
    public float hiz;
     int index;
    void Start()
    {
        index=obje.Count-1;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=Vector3.Lerp( this.transform.position , obje[index-1].transform.position, hiz*Time.deltaTime);
        
    }
}
