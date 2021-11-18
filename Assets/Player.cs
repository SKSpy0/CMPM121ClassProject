using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public float cubesCollected;
    private bool torchLightOn = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider collider){
        var box = collider.GetComponent<TestComponent>();
        if(box != null){
            cubesCollected += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {   
        //player rotation
        var transform = this.GetComponent<Transform>();
        transform.localRotation *= Quaternion.Euler(
            0.0f,
            Input.GetAxis("Horizontal") * this.rotationSpeed * Time.deltaTime,
            0.0f
        );

        //torch toggle
        if(Input.GetKeyDown("f")){
            var torch = this.GetComponent<Transform>().GetChild(0);
            var torchParticle = torch.GetComponent<ParticleSystem>();
            var light = torch.GetComponent<Transform>().GetChild(0);
            light.gameObject.SetActive(!light.gameObject.activeSelf);
            if(torchLightOn){
                torchParticle.Stop();
                torchLightOn = false;
            } else {
                torchParticle.Play();
                torchLightOn = true;
            }
        }
        
        //WASD movement
        this.GetComponent<CharacterController>().SimpleMove(
            Input.GetAxis("Vertical") * this.speed * transform.forward
        );

    }
}
