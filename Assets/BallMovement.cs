using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    Rigidbody rb;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(new Vector3(0, -3, 0));
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * 3;
    }
    private void OnCollisionEnter(Collision collision)
    {

        GameObject pew = collision.gameObject;

        pewblock enemyComponent = pew.GetComponent<pewblock>();
        
        if (collision.collider.tag == "floor")
        {

        
            transform.position = new Vector3(0.46f, 4.61f, 0);
        }
      
    }

}
