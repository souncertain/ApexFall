using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public GameObject vol;
    private string x = "";
    void Start()
    {
        string path = "Assets/volume.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        x = reader.ReadToEnd();
        reader.Close();
        var d=Convert.ToSingle(x);
        //UnityEngine.Debug.Log(d.GetType());
        vol.transform.position = new Vector3(d, -1.272f, -1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        string path = "Assets/volume.txt";
        var position = vol.transform.position.x;
        var cord = position.ToString();
        File.WriteAllText(path, cord);
    }
}
