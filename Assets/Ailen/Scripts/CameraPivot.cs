using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    public float targetAngle = 45f;
    public float currentAngle = 0f;
    public float mouseSensitivity = 2f;
    public float rotationSpeed = 5f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Input.GetMouseButton(0))
        {
            targetAngle += mouseX * mouseSensitivity;
        }

        else
        {
            targetAngle = Mathf.Round(targetAngle / 20);
            targetAngle *= 20;
        }

        if(targetAngle <0)
        {
            targetAngle += 360;
        }

        if(targetAngle>360)
        {
            targetAngle -= 360;
        }

        currentAngle = Mathf.LerpAngle(transform.eulerAngles.y,targetAngle,rotationSpeed*Time.deltaTime);
        transform.rotation = Quaternion.Euler(40, currentAngle, 0);
    }
}
