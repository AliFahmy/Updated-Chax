using UnityEngine;

public class CameraController : MonoBehaviour
{
    private bool EnableMovement;

    private float PanSpeed;
    private float ScrollSpeed;
    private float MaxY;
    private float MinY;
    void Awake()
    {
        EnableMovement = true;
        PanSpeed = 30.0f;
        ScrollSpeed = 5f;
        MinY = 10f;
        MaxY = 100f;
    }
    void Update()
    {
        if (GameManagerScript.GameEnded)
        {
            enabled = false;
            return;
        }
        if (Input.GetKey("w") )//|| Input.mousePosition.y >= Screen.height - BorderThickness)
        {
            transform.Translate(Vector3.forward * PanSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") )//|| Input.mousePosition.y <= Screen.height)
        {
            transform.Translate(Vector3.back * PanSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") )//|| Input.mousePosition.x >= Screen.width - BorderThickness)
        {
            transform.Translate(Vector3.right * PanSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") )//|| Input.mousePosition.x <= Screen.width)
        {
            transform.Translate(Vector3.left * PanSpeed * Time.deltaTime, Space.World);
        }
        float scroll=Input.GetAxis("Mouse ScrollWheel");
        Vector3 dir = transform.position;
        dir.y -= scroll * 1000 * ScrollSpeed * Time.deltaTime;
        dir.y = Mathf.Clamp(dir.y, MinY, MaxY);
        transform.position = dir;
    }
}
