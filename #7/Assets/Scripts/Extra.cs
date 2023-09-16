using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    public GameObject[] woodCylinders;
    public GameObject[] glassCylinders;
    public Boolean isChange;
    public Material wood;
    public Material glass;
    // Start is called before the first frame update
    void Start()
    {
        isChange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (!isChange)
            {
                for (int i = 0; i < woodCylinders.Length; i++)
                {
                    woodCylinders[i].GetComponent<MeshRenderer>().material = new Material(glass);
                }
                for (int i = 0; i < glassCylinders.Length; i++)
                {
                    glassCylinders[i].GetComponent<MeshRenderer>().material = new Material(wood);
                }
                isChange = true;
            }
            else {
                for (int i = 0; i < woodCylinders.Length; i++)
                {
                    woodCylinders[i].GetComponent<MeshRenderer>().material = new Material(wood);
                }
                for (int i = 0; i < glassCylinders.Length; i++)
                {
                    glassCylinders[i].GetComponent<MeshRenderer>().material = new Material(glass);
                }
                isChange = false;

            }
        }
    }
}
