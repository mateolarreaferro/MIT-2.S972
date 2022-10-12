using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //// It is possible to Debug any message
        //Debug.Log("Coding is fun!");


        //// The value of a variable

        //for (int i = 0; i < 100; i++)
        //{
        //    Debug.Log(i);
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        // It is possible to Debug a value that is changing every frame

        Debug.Log(Time.deltaTime);

        //Debug.Log(Mathf.Sin(Time.frameCount * 0.1f)); 
    }
}
