using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 200f;
    public float distance = 5f;
    public float height = 2f;
    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX += mouseX;
        player.rotation = Quaternion.Euler(0, rotationX, 0);
        rotationY -= mouseY;

        rotationY = Mathf.Clamp(rotationY, -30f, 60f);

        Quaternion rotation = Quaternion.Euler(rotationY, rotationX, 0);

        Vector3 offset = rotation * new Vector3(0, 0, -distance);

        transform.position = player.position + Vector3.up * height + offset;

        transform.LookAt(player.position + Vector3.up * height);
    }
}