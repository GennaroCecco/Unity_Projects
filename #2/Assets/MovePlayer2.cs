using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer2 : MonoBehaviour
{
    public Rigidbody player2;
    private int velo = 5;
    // Start is called before the first frame update
    void Start()
    {
        player2 = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player2.transform.Translate(Vector3.forward * velo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player2.transform.Translate(Vector3.back * velo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player2.transform.Translate(Vector3.left * velo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player2.transform.Translate(Vector3.right * velo * Time.deltaTime);
        }
    }
}
