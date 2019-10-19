using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimeManagement : MonoBehaviour
{
    [SerializeField] TMP_Text counterText;
    float counter = 600f;

    bool isCounterActive = false;
    DateTime dt1;
    DateTime dt2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isCounterActive == true)
        {
            Count();
        }
    }

    public void ResetTime()
    {
        counter = 600f;
        isCounterActive = false;
        Count();
    }

    void Count()
    {
        
        int seconds = (int)(counter % 60);
        int minutes = (int)(counter / 60);
        counter -= Time.deltaTime;
        string timeString = string.Format("{0:0} : {1:0}", minutes, seconds);
        counterText.text = timeString;
    }

    public void StartStopCounter(int val)
    {
        if(val == 0)
        {
            isCounterActive = false;
        }
        else if(val == 1)
        {
            ResetTime(); //broken
            isCounterActive = true;
        }
    }

    public void StopButtonCrasher()
    {
        if(dt1 == default(DateTime))
        {
            dt1 = DateTime.Now;
            print("dt1 = " + dt1.Second.ToString());
        }

        else if(dt2 == default(DateTime))
        {
            dt2 = DateTime.Now;
            print("dt2 = " + dt2.Second.ToString());

            TimeSpan dtRoznica = dt2 - dt1;

            if (dtRoznica.Seconds < 1)
            {
                Application.Quit();
                print("Stop pressed twice within 1 second. App crashed");
                print(dtRoznica);
                dt1 = default(DateTime);
                dt2 = default(DateTime);
            }
            else
            {
                dt1 = default(DateTime);
                dt2 = default(DateTime);
            }
        }
    }


}
