using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class WriteLog : MonoBehaviour
{
    // Start is called before the first frame update
    static string path;
    Crashes crashesFile;
    void Start()
    {
        path = "testLog.txt";
        ClearTheFile();
        crashesFile = GameObject.Find("GManager").GetComponent<Crashes>();
    }

    public void ReadString()
    {
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    void ReadStringv2()
    {
        string line = "";
        using (StreamReader sr = new StreamReader(path))
        {
            while ((line = sr.ReadLine()) != null)
            {
                Debug.Log(line);
            }
        }
    }

    public void WriteToFile()
    {
        StreamWriter writer = new StreamWriter(path, true);
        DateTime dt = DateTime.Now;
        writer.Write(dt.ToString("HH:mm:ss dd.MM.yy"));
        writer.Write("     ");
        writer.WriteLine(gameObject.name.Substring(4));
        writer.Close();
        crashesFile.ThreeBtnCrash(gameObject.name);
    }

    public void ClearTheFile()
    {
        File.WriteAllText(path, "");
    }


}