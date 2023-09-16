using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveLife : MonoBehaviour
{
    public GameObject[] life;
    private int count;
    private Vector3 initialPosition;
    public GameObject sfera;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        initialPosition = sfera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        sfera.transform.position = initialPosition;
      
            life[count].SetActive(false);
            count++;
        
    }
}
