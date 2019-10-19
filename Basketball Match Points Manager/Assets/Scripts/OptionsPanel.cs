using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class OptionsPanel : MonoBehaviour
{
    [SerializeField] GameObject optionsPanel;
    [SerializeField] InputField inpTeam1;
    [SerializeField] InputField inpTeam2;
    [SerializeField] TMP_Text team1NameTextField;
    [SerializeField] TMP_Text team2NameTextField;

    PointsManager pointsManagerScript;


    static string team1Name = "";
    static string team2Name = "";

    // Start is called before the first frame update
    void Start()
    {
        pointsManagerScript = GameObject.Find("GManager").GetComponent<PointsManager>();
        CloseOptionsPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeName(int team)
    {
        if(team == 1)
        {
            team1Name = inpTeam1.text.Trim();
            team1Name = team1Name.Replace(" ", string.Empty);
            team1NameTextField.text = team1Name;
        }
        else if(team == 2)
        {
            team2Name = inpTeam2.text;
            team2NameTextField.text = team2Name;
        }
        else
        {
            print("error");
        }
    }

    public void OpenOptionsPanel()
    {
        optionsPanel.SetActive(true);
    }

    public void CloseOptionsPanel()
    {
        optionsPanel.SetActive(false);
    }
    
    public void ResetPoints()
    {
        pointsManagerScript.ResetPoints();
    }

    public void DecreasePoints(string team)
    {
        if(team == "1")
        {
            pointsManagerScript.AddPoint(team, -1);
        }
        else
        {
            pointsManagerScript.MakePointsEqualTo1();
        }
               
    }
}
