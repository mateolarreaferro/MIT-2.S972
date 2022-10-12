using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypesScope : MonoBehaviour
{
    // -------------------- GLOBAL VARIABLE ----------------------
    int otherNumber = 3; // can be accessed from any part of the program

    void DebugNumber()
    {
        // ---------------------- LOCAL VARIABLE ------------------------------------------
        int number = 1; // this is a local variable - it was declared inside a block of code
        Debug.Log(number);
    }


    // Start is called before the first frame update
    void Start()
    {
        // 'Printing' variables into the console
        Debug.Log(otherNumber);
        DebugNumber(); // method created in line 1o
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

