
using System.Collections.Generic;

using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class ExitTrigger : MonoBehaviour
{
    public GameObject vol;
    public void OnExit()
    {
        vol.SetActive(true);
    }
}
