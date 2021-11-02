using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public Vector3 cameraTranslation;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;

        transform.Translate(cameraTranslation);
    }
}
