using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public InputController InputController;
    public GunController GunController;

	// Use this for initialization
	void Start () {
        InputController.MouseMove.Add(GunController.RotateTo);
    }	
}
