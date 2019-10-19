using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crashes : MonoBehaviour
{
    bool is3pressed, is2pressed, is1pressed;

    void Start()
    {
        is3pressed = false;
        is2pressed = false;
        is1pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CloseApp()
    {
        Application.Quit();
    }

    public void ThreeBtnCrash(string btnName)
    {
        if(btnName == "btn Team2  +3")
        {
            is3pressed = true;
        }else if(is3pressed && btnName == "btn Team2  +2")
        {
            is2pressed = true;
        }else if(is3pressed && is2pressed && btnName == "btn Team2  +1")
        {
            Application.Quit();
            print("3,2,1 for team2 pressed. app quit");
        }
        else
        {
            is3pressed = false;
            is2pressed = false;
            is1pressed = false;
        }
    }
}
