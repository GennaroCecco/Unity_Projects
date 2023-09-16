using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Create2Sphere : MonoBehaviour
{
    public GameObject sfera;  
    public Vector3 pos1,pos2;
    public Quaternion rot;
    private Boolean coll = true;
    // Start is called before the first frame update
    void Start()
    {
        sfera = GameObject.Find("sfera");
        pos1 =new Vector3((float)2.45, (float)14.91, (float)0.2500005);
        pos2 = new Vector3((float)0, (float)14.91, (float)0.2500005);
        rot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (coll)
        {
            GameObject newObject1 = Instantiate(sfera, pos1, rot);
            GameObject newObject2 = Instantiate(sfera, pos2, rot);
            coll = false;
        }
    }
}
