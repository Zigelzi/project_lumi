using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float cameraSpeed = 50f;
    [SerializeField] private Vector3 cameraOffSet = new Vector3(11f, 15f, 0f);
    [SerializeField] private Vector3 cameraRotation = new Vector3(45.5f, -90f, 0);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayerPosition();
        //MoveCameraOnMouse2Down();
    }

    void FollowPlayerPosition()
    {

        transform.position = player.transform.position + cameraOffSet;
        transform.rotation = Quaternion.Euler(cameraRotation);
    }

    void MoveCameraOnMouse2Down()
    {
        float horizontalSpeed = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(player.transform.up * horizontalSpeed * cameraSpeed * Time.deltaTime);
        }
    }
}
