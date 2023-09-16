using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWin : MonoBehaviour
{
    private PuntiPlayer1 player;
    public int punti1,punti2;
    public GameObject giocatore1,giocatore2;
    public Text text;
    private Boolean primo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = FindObjectOfType<PuntiPlayer1>();
        punti1 = player.GetPunti1();
        punti2 = player.GetPunti2();
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject == giocatore1 && primo)
        {
            primo = false;
            if (punti1 >= punti2)
            {
                text.text = "WIN";
            }
            if (punti1 <= punti2)
            {
                text.text = "DRAW";
            }
        }
        else if (other.gameObject == giocatore2 && primo)
        {
            primo = false;
            if (punti2 >= punti1)
            {
                text.text = "WIN";
            }
            if (punti2 <= punti1)
            {
                text.text = "DRAW";
            }
        }


        else if (other.gameObject == giocatore1 && !primo)
        {
            primo = false;
            if (punti1 >= punti2)
            {
                text.text = "DRAW";
            }
            if (punti1 <= punti2)
            {
                text.text = "LOSE";
            }
        }
        else if (other.gameObject == giocatore2 && !primo)
        {
            primo = false;
            if (punti2 >= punti1)
            {
                text.text = "DRAW";
            }
            if (punti2 <= punti1)
            {
                text.text = "LOSE";
            }
        }
    }
    
}
