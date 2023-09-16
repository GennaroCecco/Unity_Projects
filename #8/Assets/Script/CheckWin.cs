using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWin : MonoBehaviour
{
    public static int count = 0;
    public Text text;
    public new Renderer renderer;
    public Boolean pass = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( pass==false)
        {
            count = count + 1;
        }
        if (count == 3) { text.text = "WIN!"; }
        Debug.Log(count);
        pass = true;
       
    }
}
