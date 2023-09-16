using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public new Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
      renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnCollisionEnter(Collision collision)
    {
        Color color = new Color(Random.value, Random.value, Random.value);
        renderer.material.color = color;
    }
}
