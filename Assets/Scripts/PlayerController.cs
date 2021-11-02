using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MAX_SPEED = 10.0f;
    public float ACCELERATION = 0.1f;

    public float ROTATION_SPEED = 2f;

    public bool IsMoving = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * ROTATION_SPEED;
        float vert = Input.GetAxis("Vertical") * Time.fixedDeltaTime * MAX_SPEED;

        IsMoving = horiz != 0f || vert != 0f;

        transform.Translate(0, 0, vert);
        transform.Rotate(0, horiz, 0);
    }
}
