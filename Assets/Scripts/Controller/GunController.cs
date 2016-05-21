using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour
{

    public Texture2D CrosshairTexture;

    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(CrosshairTexture, new Vector2(CrosshairTexture.width/2, CrosshairTexture.height/2), CursorMode.Auto);
    }

    public void RotateTo(Vector3 to)
    {
        var cam = Camera.main;
        var my = transform.position;
        // Distance from camera to object.  We need this to get the proper calculation.
        float camDis = cam.transform.position.y - transform.position.y;

        // Get the mouse position in world spaaaaaace. Using camDis for the Z axis.
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle-90));

      /*  var object_pos = Camera.main.WorldToScreenPoint(transform.position);
        to.x = to.x - object_pos.x;
        to.y = to.y - object_pos.y;
        var angle = Mathf.Atan2(to.y, to.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        */
    }

    public void Fire()
    {
        
    }
}
