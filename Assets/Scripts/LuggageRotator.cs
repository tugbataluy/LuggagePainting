using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using DG.Tweening;
public class LuggageRotator : MonoBehaviour
{
    private Touch touch;
    private Vector2 touch_pos;
    private Quaternion rotationY;

    private float rotation_speed=0.1f;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
       /* if (Input.touchCount>0){
            touch=Input.GetTouch(0);
            if(touch.phase==TouchPhase.Moved){
                rotationY=Quaternion.Euler(0f,-touch.deltaPosition.x*rotation_speed,0f);
                transform.rotation=rotationY*transform.rotation;
            }

        }*/
    }
    public void RotateLeft(){
        rotationY=Quaternion.Euler(0f,30,0f);
        transform.rotation=rotationY*transform.rotation;

    }

    public void RotateRight(){
        rotationY=Quaternion.Euler(0f,-30,0f);
        transform.rotation=rotationY*transform.rotation;

    }
}
