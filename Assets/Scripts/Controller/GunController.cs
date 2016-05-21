using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour
{

    public Texture2D CrosshairTexture;

    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(CrosshairTexture, Vector2.zero, CursorMode.Auto);
    }

    public void RotateTo(Vector3 to)
    {
        var object_pos = Camera.main.WorldToScreenPoint(transform.position);
        to.x = to.x - object_pos.x;
        to.y = to.y - object_pos.y;
        var angle = Mathf.Atan2(to.y, to.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

    }

    public void Fire()
    {
        
    }
}
