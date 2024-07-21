using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTr : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] GameObject text2;
    public void ChangePermis()
    {
        bool a = text1.activeInHierarchy;
        text1.SetActive(!a);
        text2.SetActive(a);
    }
}
