using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class InputController : MonoBehaviour
{

    public List<Action<Vector3>> MouseMove;
    public List<Action> Fire1;

    private Vector3 _lastPos;

    public InputController()
    {
        MouseMove = new List<Action<Vector3>>();
        Fire1 = new List<Action>();
    }

    // Update is called once per frame
    void Update()
    {
        var curPos = Input.mousePosition;
        if (_lastPos != curPos)
        {
            _lastPos = curPos;
            MouseMove.ForEach(action => action(_lastPos));
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Fire1.ForEach(action => action());
        }
    }
}
