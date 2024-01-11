using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBody : MonoBehaviour
{
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X");
        this.transform.Rotate(Vector3.up * mouseX);
    }
}
