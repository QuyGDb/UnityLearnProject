using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotateSpeed;
    float horizontal;
    float vertical;
    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    horizontal = Input.GetAxis("Horizontal");
    //    vertical = Input.GetAxis("Vertical");
    //    transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
    //    transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * horizontal);
    //}
    private void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * speed * vertical);
        rb.AddTorque(Vector3.up * rotateSpeed * horizontal);
    }
}
