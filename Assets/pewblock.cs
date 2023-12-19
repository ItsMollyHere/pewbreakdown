using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewblock : MonoBehaviour
{
    // Start is called before the first frame update

    public int Blockhp = 5;

    public void Blockhealth()
    {
        Blockhp -= 1; 

        if (Blockhp == 0)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ball")
        {
            Blockhealth();
        }

        
    }  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
