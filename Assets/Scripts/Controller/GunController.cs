using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {

    public Texture2D CrosshairTexture;

	// Use this for initialization
	void Start () {
        Cursor.SetCursor(CrosshairTexture, Vector2.zero, CursorMode.Auto);        
	}
	
    void OnGUI()
    {
        
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
