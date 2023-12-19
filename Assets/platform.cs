using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class platform : MonoBehaviour  
{

    [SerializeField] Rigidbody rb;

    public float speedL = 1;

    public float speedR = 1;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {

            rb.AddForce(new Vector3(speedL, 0, 0), ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(new Vector3(-speedR, 0, 0), ForceMode.Impulse);

        }

    }
}
