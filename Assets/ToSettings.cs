using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSettings : MonoBehaviour
{
    public int scene;
    public void ToSet()
    {
        SceneManager.LoadScene(scene);
    }
}
