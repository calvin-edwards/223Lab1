using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    float speed = 1;

    void Update()
    {
        transform.Rotate(Vector3.left, 90 * Time.deltaTime * speed);
    }
}