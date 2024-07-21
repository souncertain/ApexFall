using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Platform : MonoBehaviour
{

    private PlatformEffector2D effector;


    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            effector.rotationalOffset = 180f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            effector.rotationalOffset = 0;
        }
    }
}
