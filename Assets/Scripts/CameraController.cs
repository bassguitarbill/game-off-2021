using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public Vector3 cameraTranslation;

    public float cameraRotationXSpeed = 100f;

    private Vector3 cameraRotationOffset = new Vector3();
    private float cameraXOffset = 0f;
    public float cameraXResetFactor = 0.95f;

    private PlayerController pc;

    void Awake()
    {
        pc = target.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;

        float mouseX = Input.GetAxis("Mouse X");
        cameraXOffset += mouseX * Time.deltaTime * cameraRotationXSpeed;
        if (pc.IsMoving)
        {
            cameraXOffset *= cameraXResetFactor;
        }

        transform.RotateAround(transform.position, Vector3.up, cameraXOffset);

        transform.Translate(cameraTranslation);
    }
}
