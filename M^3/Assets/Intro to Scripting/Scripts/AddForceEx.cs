using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceEx : MonoBehaviour
{
    Rigidbody rb;
    public bool goingUp = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp)
        {
            rb.AddForce(new Vector3(0, 100f, 0) * Time.deltaTime);
            
        }
        
    }
}
