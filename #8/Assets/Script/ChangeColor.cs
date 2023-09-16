using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Button btn;
    public new Renderer renderer;
    public Boolean count = false;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Clicked()
    {
        if (count == true)
        {
            renderer.material.color = new Color(0.18f, 0.21f, 0.25f);
            count = false;
        }
        else {
            renderer.material.color = new Color(0.6f, 0.32f, 0.28f);
            count = true;
        }
    }

    
}
