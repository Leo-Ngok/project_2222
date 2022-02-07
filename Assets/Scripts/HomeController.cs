#define DEBUG
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {

        }
        else if(Input.GetKeyDown(KeyCode.F10))
        {

        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Btn_Exit_Click();
        }
    }
    public void Btn_Entry_Click()
    {
        
    }
    public void Btn_Settings_Click()
    {
        
    }
    public void Btn_Exit_Click()
    {
#if DEBUG
        Debug.Log("Quit invoked");
#endif
        Application.Quit(0);
    }
}
