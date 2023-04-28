using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject ColorContainer;
   
    void Start()
    {
       
       
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void ChangeColor(){
       for(int i=0;i<ColorContainer.transform.childCount;i++)
        {
            if(ColorContainer.transform.GetChild(i).gameObject.activeInHierarchy){
                Color changed=ColorContainer.transform.GetChild(i).gameObject.GetComponent<P3dPaintSphere>().Color;
                //print(changed);
               this.GetComponent<MeshRenderer>().material.color=changed;
             

            }
        }

    }
}
