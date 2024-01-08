using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playTransform;
    Vector3 offset;
    void Start()
    {
        offset = playTransform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = playTransform.position - offset;
        //phép quay bằng toán học, quaterion nhân với vector3
        transform.position = playTransform.position - playTransform.rotation * offset;
        transform.LookAt(playTransform);
    }
}
