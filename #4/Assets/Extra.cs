using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Extra : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(Reset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Reset()
    {
        Debug.Log("ciao");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
