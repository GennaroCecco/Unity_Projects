using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public static int count = 0;
    public Text text;
    private Renderer renderer;
    public Material material;
    public GameObject cubo;
    // Start is called before the first frame update
    void Start()
    {
        renderer = cubo.GetComponent<Renderer>();
        material = renderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        count++;
        text.text = "Rimbalzi: " + count;
        if (count >= 10 && count % 10 == 0) {
            Color color = new Color(Random.value,Random.value,Random.value);
            color.a = material.color.a;
            material.color = color;
        }
    }
    
    public void SetCountZero() {
        count = 0;
        this.text.text = "Rimbalzi: " + count;
    }
}
