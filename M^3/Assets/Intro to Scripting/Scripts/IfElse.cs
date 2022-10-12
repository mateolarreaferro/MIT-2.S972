using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    // Variable

    bool hasCovid; // true or false

    // Start is called before the first frame update
    void Start()
    {
        hasCovid = true;


        if (hasCovid)
        {
            Debug.Log("Aubrey will host tonight's Cave session");
        }
        else
        {
            Debug.Log("Mateo will host tonight's Cave session");
        }
        
    }
}


