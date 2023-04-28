using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_to_blur : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prev;
    public GameObject next;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadyToBlur(){
        prev.gameObject.SetActive(false);
       
        next.gameObject.SetActive(true);
        this.transform.eulerAngles=new Vector3(0,0,0);

    }
}
