using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class AllPermision : MonoBehaviour
{
    private string flag = "";
    void Start()
    {

        string path = "Assets/resol.txt";
        StreamReader reader = new StreamReader(path);
        flag = reader.ReadToEnd();
        reader.Close();
        if (flag == "2")
        {
            Screen.SetResolution(1280, 720, true);
        }
        else
        {
            if (flag == "9")
            {
                Screen.SetResolution(1920, 1080, true);
            }
        }
    }

}
