using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody body;
    public int velo = 1;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
           body.AddForce(Vector3.left * velo, ForceMode.Impulse);
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(Vector3.right * velo, ForceMode.Impulse);
           
        }
    }   
}
