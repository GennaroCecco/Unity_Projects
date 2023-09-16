using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra : MonoBehaviour
{
    public Renderer renderer1, renderer2;
    public GameObject giocatore1,giocatore2;
    // Start is called before the first frame update
    void Start()
    {
        renderer1 = GetComponent<Renderer>();
        renderer2 = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == giocatore1)
        {
            Color color = new Color(Random.value, Random.value, Random.value);
            renderer1.material.color = color;
            
        }
        else {
            Color color = new Color(Random.value, Random.value, Random.value);
            renderer2.material.color = color;
        }
    }
}
