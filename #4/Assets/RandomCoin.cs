using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RandomCoin : MonoBehaviour
{
    public int numCoin;
    public GameObject objectPrefab;  // Il prefab dell'oggetto da creare
    public Vector3 pos;
    public Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        objectPrefab = GameObject.Find("Coin");
        pos = transform.position;
        rot = objectPrefab.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Destroy(this.gameObject);
        for (int i = 0; i < numCoin; i++)
        {
            float x = Random.Range(12, -12);
            float z = Random.Range(12, -12);
            pos = new Vector3(x, 2, z);
            GameObject newObject = Instantiate(objectPrefab, pos, rot);

        }
    }
}
