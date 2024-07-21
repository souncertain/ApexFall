using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continue : MonoBehaviour
{
    public GameObject panel;
    public GameObject pause;
    public void contingame()
    {
        panel.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1f;
    }
}
