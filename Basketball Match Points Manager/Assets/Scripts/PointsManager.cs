using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{

    [SerializeField] TMP_Text team1pointsText;
    [SerializeField] TMP_Text team2pointsText;
    [SerializeField] Text team1PointsOptionPanel;
    [SerializeField] Text team2PointsOptionPanel;

    static public int team1Points = 0;
    static public int team2Points = 0;

    public int GetTeamPoints(int team)
    {
        if(team == 1)
        {
            return team1Points;
        }
        else if(team == 2)
        {
            return team2Points;
        }
        else
        {
            return 0;
        }
        
    }

    public int GetTeam2Points()
    {
        return team2Points;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPoints()
    {
        team1Points = 0;
        team2Points = 0;
        UpdatePoints("1");
        UpdatePoints("2");
    }

    public void AddPoint(string team, int points)
    {
        if(team == "1")
        {
            team1Points += points;
            UpdatePoints(team);
            print(team1Points);
        }
        else if(team == "2")
        {
            team2Points += points;
            UpdatePoints(team);
            print(team2Points);
        }
        else
        {
            print("sth wrong");
        }
    }

    void UpdatePoints(string team)
    {
        if(team == "1")
        {
            if (team1Points < 10)
            {
                team1pointsText.text = "00" + team1Points.ToString();
                team1PointsOptionPanel.text = "00" + team1Points.ToString();
            }
            else if (team1Points < 100)
            {
                team1pointsText.text = "0" + team1Points.ToString();
                team1PointsOptionPanel.text = "0" + team1Points.ToString();
            }
            else
            {
                team1pointsText.text = team1Points.ToString();
                team1PointsOptionPanel.text = team1Points.ToString();
            }
        }
        else if (team == "2")
        {
            if (team2Points < 10)
            {
                team2pointsText.text = "00" + team2Points.ToString();
                team2PointsOptionPanel.text = "00" + team2Points.ToString();
            }
            else if (team2Points < 100)
            {
                team2pointsText.text = "0" + team2Points.ToString();
                team2PointsOptionPanel.text = "0" + team2Points.ToString();
            }
            else
            {
                team2pointsText.text = team2Points.ToString();
                team2PointsOptionPanel.text = team2Points.ToString();
            }
        }
        else
        {
            print("sth wrong with points");
        }
    }

}
