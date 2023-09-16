using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Counter : MonoBehaviour
{
    public static int count = 5;
    public Text text;
    public GameObject objectPrefab;  // Il prefab dell'oggetto da creare
    public KeyCode keyToPress = KeyCode.W;
    public Vector3 pos;
    public Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        objectPrefab = GameObject.Find("cil");
        pos = objectPrefab.transform.position;
        rot = objectPrefab.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Blocchi in piedi: " + count;
        if (Input.GetKeyDown(keyToPress))
        {
            // Crea un nuovo oggetto utilizzando il prefab e la posizione corrente del giocatore
            GameObject newObject = Instantiate(objectPrefab, pos, rot);
            // Assegna un nome univoco all'oggetto creato
            newObject.name = "New Object";
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.name == "Palo")
        {
            count--;
            Destroy(other.gameObject);

        }
       
       Debug.Log(count);
       
    }
}
