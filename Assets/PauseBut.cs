using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBut : MonoBehaviour
{
    public GameObject panel;
    public GameObject pause1;
    public void pause()
    {
        panel.SetActive(true);
        pause1.SetActive(false);
        Time.timeScale = 0;
    }
}
