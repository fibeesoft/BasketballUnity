using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BtnPointClick : MonoBehaviour
{
    PointsManager pointsManagerScript;

    
    void Start()
    {
        pointsManagerScript = GameObject.Find("GManager").GetComponent<PointsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetButtonName()
    {
        //print(this.GetComponent<TMP_Text>().text);
        print(this.name);
    }

    public void AddPoint()
    {
        string btnName = this.name;
        string team = btnName.Substring(0, 1);
        int points = int.Parse(btnName.Substring(2, 1));
        pointsManagerScript.AddPoint(team, points);
    }
}
