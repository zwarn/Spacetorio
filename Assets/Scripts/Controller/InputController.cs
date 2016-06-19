using UnityEngine;
using System;
using System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public class InputController : MonoBehaviour
{
    public static InputController Instance;

    public List<Action<Vector3>> MouseMove;
    public List<Action> Fire1;
    private Player player;

    private Vector3 _lastPos;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

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

        if (player != null)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            Vector2 direction = new Vector2(x, y);
            if (direction.magnitude > 1f)
            {
                direction.Normalize();
            }
            player.move(direction);
        }
    }

    public void registerPlayer(Player player)
    {
        this.player = player;
    }
}
