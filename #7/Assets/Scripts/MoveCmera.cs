using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCmera : MonoBehaviour
{
    public Transform toFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(toFollow);
    }
}
