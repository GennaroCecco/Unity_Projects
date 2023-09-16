using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntiPlayer1 : MonoBehaviour
{
    public static int punti1;
    public static int punti2;
    public Text text1,text2;
    public GameObject giocatore1, giocatore2;
    public new Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        punti1 = 10;
        punti2 = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (renderer.enabled)
        {


            if (other.gameObject == giocatore1)
            {
                punti1--;
                text1.text = "Player1: " + punti1;
            }
            else if (other.gameObject == giocatore2)
            {
                punti2--;
                text2.text = "Player2: " + punti2;
            }

            renderer.enabled = false;
        }
    }

    public int GetPunti1() { 
        return punti1;
    }
    public int GetPunti2()
    {
        return punti2;
    }
}
