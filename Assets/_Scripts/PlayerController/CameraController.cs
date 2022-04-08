using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // cache the distance
        offset = transform.position - target.position;

    }

    // Update is called once per frame
    void Update()
    {
        // snap to center, then back out
        transform.position = target.transform.position + offset;
    }
}
