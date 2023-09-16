using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour

{
    public Rigidbody player1;
    private int velo = 5;
    // Start is called before the first frame update
    void Start()
    {
        player1 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
        {
            player1.transform.Translate(Vector3.forward * velo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player1.transform.Translate(Vector3.back * velo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player1.transform.Translate(Vector3.left * velo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player1.transform.Translate(Vector3.right * velo * Time.deltaTime);
        }
    }
}
