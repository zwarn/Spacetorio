using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public InputController InputController;
    public GunController GunController;
    public static GameController Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        InputController.MouseMove.Add(GunController.RotateTo);
        InputController.Fire1.Add(GunController.Fire);
        // Do map setup here
    }


    void Start()
    {

    }

    void Update()
    {

    }
}