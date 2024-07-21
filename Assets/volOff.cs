using System.Collections.Generic;

using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class volOff : MonoBehaviour
{
    [SerializeField] GameObject vol1;
    public void volOfff()
    {
        vol1.SetActive(false);
    }
}
