using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class StickerFollow : MonoBehaviour {

    List<GameObject> added =new List<GameObject>();
    GameObject sticked;
    GameObject button;
    public GameObject buttons;
    bool isCreated=false;
    public GameObject sticker;
    public GameObject decal;
 Vector3 worldPosition;
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;
        if(Physics.Raycast(ray, out hitData, 1000))
            {
                worldPosition = hitData.point;
								this.transform.position=Vector3.Lerp(transform.position,new Vector3(worldPosition.x,worldPosition.y,worldPosition.z-3),1);
                                Vector3 pos=new Vector3(worldPosition.x,worldPosition.y,worldPosition.z);
                               
                          

                             if(Input.GetMouseButtonDown(0) && !hitData.transform.CompareTag("Sticker") && !hitData.transform.CompareTag("Rotate")&& !hitData.transform.CompareTag("Expand") && !hitData.transform.CompareTag("Shrink") && !hitData.transform.CompareTag("Delete"))   
                                {
                                    sticked=Instantiate(sticker,pos,Quaternion.identity);
                                    sticked.tag="Sticker";
                                    added.Add(sticked);
                                    for (int i=0;i<added.Count-1;i++){
                                        added[i].transform.GetChild(0).gameObject.SetActive(false);
                                    }
                                }
                            else if(Input.GetMouseButtonDown(0)&& hitData.transform.CompareTag("Sticker")){
                                  hitData.transform.GetChild(0).gameObject.SetActive(true);

                            }
                           
                                else if(Input.GetMouseButtonDown(0) && hitData.transform.CompareTag("Rotate"))
                                {
                                       hitData.transform.parent.transform.parent.Rotate(0,0,30);
                                        
                                      // print("rotate");
                                      }
                                     else if(Input.GetMouseButtonDown(0) && hitData.transform.CompareTag("Expand") )
                                    {
                                        hitData.transform.parent.transform.parent.localScale=hitData.transform.parent.transform.parent.localScale+new Vector3(.2f,.2f,.2f);
                                         
                                       //print("expand");
                                       }
                                    else if(Input.GetMouseButtonDown(0) && hitData.transform.CompareTag("Shrink"))
                                    {

                                         hitData.transform.parent.transform.parent.localScale=hitData.transform.parent.transform.parent.localScale-new Vector3(.2f,.2f,.2f);
                                       //print("shrink");
                                       }
                                    else if(Input.GetMouseButtonDown(0) && hitData.transform.CompareTag("Delete") )
                                    {
                                        added.Remove(hitData.transform.parent.transform.parent.gameObject);
                                        Destroy( hitData.transform.parent.transform.parent.gameObject);
                                        
                                       //print("delete");
                                       }

                                  


                                  
                                  
                                 
                            }
				else{
                     for (int i=0;i<added.Count;i++){
                                        added[i].transform.GetChild(0).gameObject.SetActive(false);
                                    }
                
                }			

		}
       
       
        
						
				

    }



