using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject ball;

    void Update()
    {
        transform.position = ball.transform.position + new Vector3(0, 0, -10);
    }
}
