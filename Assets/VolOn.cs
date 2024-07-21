using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class VolOn : MonoBehaviour
{
    [SerializeField] GameObject vol;
    public void volOn()
    {
        vol.SetActive(true);

    }
}
