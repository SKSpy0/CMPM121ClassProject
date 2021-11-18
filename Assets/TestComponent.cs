using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{

    float moveX = 0.00f;
    bool moveLeft = false;

    bool disappearing = false;

    // Start is called before the first frame update
    void Start()
    {
        /*set color to what last color was before, if there is none then default is white 
        var startColor = new Color(PlayerPrefs.GetFloat("cube.colorR", 255), PlayerPrefs.GetFloat("cube.colorG", 255), PlayerPrefs.GetFloat("cube.colorB", 255));
        this.GetComponent<Renderer>().material.color = startColor;
        */
    }


    // Update is called once per frame
    void Update()
    {
        var transform = this.GetComponent<Transform>();
        var renderer = this.GetComponent<Renderer>();
        
        if(transform.position.x <= -10.0f){
            moveLeft = false;
        }
        if(transform.position.x >= 10.0f){
            moveLeft = true;
        }

        if(moveLeft){
            moveX = -0.01f;
        } else {
            moveX = 0.01f;
        }

        transform.position = transform.position + new Vector3(moveX, 0, 0);

        //variables for rotation
        float tiltAngle = 60.0f;
        transform.Rotate(0, tiltAngle * Time.deltaTime,0);

        /*change color to something random with SPACE
        float colorR = 0.0f;
        float colorG = 0.0f;
        float colorB = 0.0f;
        if(Input.GetKeyDown(KeyCode.Space)){
            colorR = Random.Range(-10.0f, 10.0f);
            colorG = Random.Range(-10.0f, 10.0f);
            colorB = Random.Range(-10.0f, 10.0f);
            renderer.material.color = new Color(colorR, colorG, colorB);

            //save current color for restart
            PlayerPrefs.SetFloat("cube.colorR", colorR);
            PlayerPrefs.SetFloat("cube.colorG", colorG);
            PlayerPrefs.SetFloat("cube.colorB", colorB);
        }*/

        if(this.disappearing){
            var scale = transform.localScale;
            scale *= 0.99f;
            transform.localScale = scale;
        }
    }

    private void OnTriggerEnter(Collider collider){
        var player = collider.GetComponent<Player>();
        if(player != null){
            GameObject.Destroy(this.gameObject, 2.0f);
            this.disappearing = true;
        }
    }
}
