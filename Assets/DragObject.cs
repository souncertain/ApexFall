using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public GameObject lighting;
    private void OnMouseDrag()
    {
        this.transform.position = GetMousePosition();
        lighting.SetActive(true);

    }

    private Vector3 GetMousePosition()
    {
        var _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mousePosition.z = -1;
        _mousePosition.y = -1.272f;
        if(_mousePosition.x >= -3.02f)
        {
            _mousePosition.x = -3.02f;
        }
        if (_mousePosition.x <= -6.219f)
        {
            _mousePosition.x = -6.219f;
        }
        return _mousePosition;
    }

    
}
