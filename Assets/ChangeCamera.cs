using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public Camera firstperson;
    public Camera thirdperson;
    bool is3rdPersonCamera = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(is3rdPersonCamera){
            firstperson.enabled = true;
            thirdperson.enabled = false;
        } else {
            firstperson.enabled = false;
            thirdperson.enabled = true;
        }
    }
    
    public void ButtonWasClicked(){
        if(is3rdPersonCamera){
            is3rdPersonCamera = false;
        } else {
            is3rdPersonCamera = true;
        }
    }
}
