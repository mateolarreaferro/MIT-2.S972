using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorqueEx : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(new Vector3(0, 90, 0) * Time.deltaTime);

        
    }
}
