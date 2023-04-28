using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class MouseFollow : MonoBehaviour {

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
            
							if(Input.GetMouseButtonDown(0)){
							this.transform.GetChild(0).gameObject.SetActive(true);
							this.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>().Play();

				}
							if(Input.GetMouseButtonUp(0)){
							this.transform.GetChild(0).gameObject.SetActive(false);}
						
						}
				

    }


}
