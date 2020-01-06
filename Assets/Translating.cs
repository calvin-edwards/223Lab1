using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translating : MonoBehaviour
{
    Vector3 _startPosition;

    void Start()
    {
        _startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = _startPosition + new Vector3(0.0f, 0.0f, Mathf.Sin(Time.time)*2);
    }
}
