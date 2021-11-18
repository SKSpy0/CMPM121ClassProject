using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerScript = Player.GetComponent<Player>();
        var transform = this.GetComponent<Transform>();

        if(playerScript.cubesCollected >= 3 && transform.position.y <= transform.position.y + 40){
            transform.position = transform.position + new Vector3(0, 0.05f, 0);
        }
    }
}
