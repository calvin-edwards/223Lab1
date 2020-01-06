using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldAxisRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 90 * Time.deltaTime, Space.World);
    }
}
