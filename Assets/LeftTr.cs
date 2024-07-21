
using System.Collections.Generic;

using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class LeftTr : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    public void ChangePerm()
    {
        bool a = text1.activeInHierarchy;
        text1.SetActive(!a);
        text2.SetActive(a);
    }
}
