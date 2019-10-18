using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WriteLog : MonoBehaviour
{
    // Start is called before the first frame update
    private string fileName;
    FileStream fs;
    StreamWriter sw;
    void Start()
    {
        //fileName = @"d://test.txt";
        fileName = "test.txt";
        fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

    }

    public void WriteToFile(string message){
        sw = new StreamWriter(fs);
        fs.Seek(0, SeekOrigin.End);
        DateTime dt = DateTime.Now;
        sw.Write(dt.ToString("HH:mm:ss dd.MM.yy"));
        sw.Write("     ");
        sw.WriteLine(message);
        sw.WriteLine();
        sw.Flush();
        //sw.Close();
    }
}
