using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //the object we want to follow
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        //calculate an offset if needed
        Vector3 offset = new Vector3(0, -.5f, 0);
        //update the transform of this object
        transform.position = target.position + offset;
    }
}
