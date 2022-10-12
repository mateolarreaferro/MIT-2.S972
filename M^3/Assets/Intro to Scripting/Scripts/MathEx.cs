using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathEx : MonoBehaviour
{
    float rate = 3f;

    // Update is called once per frame
    void Update()
    {
        // Sin

        float sinVariable = Mathf.Sin(Time.time) * rate;
        transform.localScale = new Vector3(sinVariable, sinVariable, sinVariable);
        
    }
}
