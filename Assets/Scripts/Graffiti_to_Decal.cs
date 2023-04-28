using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graffiti_to_Decal : MonoBehaviour
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

    public void Start_to_Decal(){
        prev.SetActive(false);
        next.SetActive(true);
        this.transform.eulerAngles=new Vector3(0,0,0);
        this.GetComponent<BoxCollider>().enabled=true;
    }
}
