using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraScript : MonoBehaviour
{
    private float speed= 20f;
    private float turnspeed =45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        movement();
    }
    public void movement(){
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up , horizontalInput * turnspeed * Time.deltaTime);
        transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);
       
    }
}
