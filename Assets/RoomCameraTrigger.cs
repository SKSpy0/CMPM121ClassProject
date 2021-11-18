using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCameraTrigger : MonoBehaviour
{
    public GameObject roomCamera1;
   private void OnTriggerEnter(Collider collider){
       if(collider.GetComponent<Player>()){
           Debug.Log("player enter trigger");
           this.roomCamera1.SetActive(true);
       }
   }
   private void OnTriggerExit(Collider collider){
       if(collider.GetComponent<Player>()){
           Debug.Log("player exit trigger");
           this.roomCamera1.SetActive(false);
       }
   }
}
