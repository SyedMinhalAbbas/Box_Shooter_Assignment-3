using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed =10.0f ;
    [SerializeField] float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
         forwardInput= Input.GetAxis("Vertical");
       // if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //we want to move here
            // we need transform
            transform.Translate(Vector3.forward * speed * Time.deltaTime*forwardInput);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);


        }
    }
}
