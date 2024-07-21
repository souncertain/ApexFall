
using System.Collections.Generic;

using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class ExitTriggerOff : MonoBehaviour
{
    [SerializeField] GameObject exit1;
    public void OffExit()
    {
        exit1.SetActive(false);
    }
}
