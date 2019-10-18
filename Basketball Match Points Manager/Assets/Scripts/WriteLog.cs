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
    void Start()
    {
        path = "testLog.txt";
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
    }

    public void ClearTheFile()
    {
        File.WriteAllText(path, "");
    }


}