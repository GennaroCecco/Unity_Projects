using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strike : MonoBehaviour
{
    public Image img;
   
    void Start()
    {
        img.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        img.enabled = true;
    }
}
