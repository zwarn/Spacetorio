using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour
{

    public Texture2D CrosshairTexture;
    public GameObject Bullet;
    public GameObject SpawnPoint;
    public Consumer BulletConsumer;

    private Vector3 _to;
    private int _ammunition;

    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(CrosshairTexture, new Vector2(CrosshairTexture.width / 2, CrosshairTexture.height / 2), CursorMode.Auto);
        BulletConsumer.onConsume = () => _ammunition++;
    }

    public void RotateTo(Vector3 to)
    {
        var cam = Camera.main;
        var my = transform.position;
        // Distance from camera to object.  We need this to get the proper calculation.
        float camDis = cam.transform.position.y - transform.position.y;

        // Get the mouse position in world space. Using camDis for the Z axis.
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(to.x, to.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }

    public void Fire()
    {        
        if (_ammunition > 0)
        {
            _ammunition--;
            var bullet = ((GameObject)Instantiate(Bullet, SpawnPoint.transform.position, transform.rotation)).GetComponent<BulletController>();
        }
    }
}
