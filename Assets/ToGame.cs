using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame : MonoBehaviour
{
    public void ChangeScenes()
    {
        SceneManager.LoadScene(2);
    }
}
