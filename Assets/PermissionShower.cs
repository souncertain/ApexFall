using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class PermissionShower : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    private string flag="";
    void Start()
    {
        //if (Screen.currentResolution[1]=='9')
        string path = "Assets/resol.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        flag = reader.ReadToEnd();
        reader.Close();
        if (flag == "2")
        {
            Screen.SetResolution(1280, 720, true);
            text1.SetActive(false);
            text2.SetActive(true);
        }
        else
        {
            if(flag == "9")
            {
                text1.SetActive(true);
                text2.SetActive(false);
                Screen.SetResolution(1920, 1080, true);
            }
        }
    }



    void Update()
    {

        if ((text1.activeInHierarchy == true)&&(flag=="2"))
        {
            Screen.SetResolution(1920, 1080,true);
            flag = "9";
            string path = "Assets/resol.txt";
            //Write some text to the test.txt file
            //StreamWriter writer = new StreamWriter(path, true);
            File.WriteAllText(path,"9");
            //writer.WriteAllLines(path, "");
            //writer.Close();
        }
        else
        {
            if ((text2.activeInHierarchy == true) && (flag == "9"))
            {
                Screen.SetResolution(1280, 720, true);
                flag = "2";
                string path = "Assets/resol.txt";
                //Write some text to the test.txt file
                //StreamWriter writer = new StreamWriter(path, true);
                File.WriteAllText(path, "2");
                //writer.WriteAllLines(path, "");
                //writer.Close();
            }
        }
        //UnityEngine.Debug.Log(Screen.currentResolution[1]);
    }
}
