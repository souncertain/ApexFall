using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using UnityEngine;
using UnityEngine.UI;

public class ButCoord : MonoBehaviour
{
    [SerializeField] GameObject circ;
    public RectTransform butt;
    public GameObject light;
    private float k1 = 6.219f - 3.02f;
    private float k2 = 671.72f - 326.2f;
    void Start()
    {
        var position_circ_x = circ.transform.position.x;
        var position_circ_y = circ.transform.position.y;
        //UnityEngine.Debug.Log(butt.transform.position.x);
        float v1 = (6.219f + position_circ_x) / k1;
        float v2 = -671.72f + v1 * k2;
        light.transform.position = new Vector3(position_circ_x, position_circ_y, 0f);
        butt.anchoredPosition = new Vector3(v2, position_circ_y - 136.158f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        var position_circ_x = circ.transform.position.x;
        var position_circ_y = circ.transform.position.y;
        //UnityEngine.Debug.Log(butt.transform.position.x);
        float v1 = (6.219f + position_circ_x) / k1;
        float v2 = -671.72f + v1 * k2;
        light.transform.position = new Vector3(position_circ_x, position_circ_y, 0f);
        butt.anchoredPosition = new Vector3(v2, position_circ_y - 136.158f, 0f);
        //butt.transform.position = new Vector3(-500f, -136.158f, 0f);
    }
}
