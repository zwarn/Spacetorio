using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public InputController InputController;
    public GunController GunController;
    public static GameController Instance;
    public State State;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        InputController.MouseMove.Add(GunController.RotateTo);

        State = new State(10);
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                State.getTile(x, y).Speed = 1;
                State.getTile(x, y).Dir = ((x + y) % 2 == 0) ? Direction.North : Direction.East;
            }
        }
    }


    void Start()
    {

    }

    void Update()
    {

    }
}