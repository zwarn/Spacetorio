using UnityEngine;
using System.Collections;
using System;

public class InputController : MonoBehaviour {

    public Action<Vector3> MouseMove;
    public Action Fire1;

    private Vector3 _lastPos;

	// Update is called once per frame
	void Update () {
        var curPos = Input.mousePosition;
        if (_lastPos != curPos)
        {
            _lastPos = curPos;
            if (MouseMove != null) MouseMove(_lastPos);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (Fire1 != null) Fire1();
        }
	}
}
