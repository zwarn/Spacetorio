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
        InputController.Fire1.Add(GunController.Fire);

        State = new State(10);
        // Do map setup here
    }


    void Start()
    {

    }

    void Update()
    {

    }
}