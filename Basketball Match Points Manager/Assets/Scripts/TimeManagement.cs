using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManagement : MonoBehaviour
{
    [SerializeField] TMP_Text counterText;
    float counter = 600f;

    bool isCounterActive = false;

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
            isCounterActive = true;
        }
    }


}
