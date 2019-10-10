using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateButtons : MonoBehaviour
{
    [SerializeField] GameObject btnPrefab;
    [SerializeField] GameObject[] btnParentArray;

    void Start()
    {
        CreateButtonsForSettingPoints(1);
        CreateButtonsForSettingPoints(2);
        
    }

    void CreateButtonsForSettingPoints(int teamNumber)
    {
        float posX = -200f;
        float posY = -220f;

        for(int i = 1; i < 4; i++)
        {
            GameObject btnPoint = Instantiate(btnPrefab);
            btnPoint.transform.SetParent(btnParentArray[teamNumber - 1].GetComponent<Transform>());
            btnPoint.transform.localScale = new Vector2(1, 1);
            btnPoint.transform.localPosition = new Vector3(posX, posY, 1);
            btnPoint.name = $"team{teamNumber}_{i}";
            btnPoint.GetComponentInChildren<TMP_Text>().text = i.ToString();
            posX += 200;
        }
    }
}
