using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colleziona : MonoBehaviour
{
    public static int punti = 0;
    public Text text;
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
        punti++;
        text.text = "Punti: " + punti;
        Destroy(this.gameObject);
    }
}
