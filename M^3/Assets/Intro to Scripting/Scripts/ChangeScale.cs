using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    Vector3 scaleChange = new Vector3(0.1f, 1f, 0.2f);
  
    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange * Time.deltaTime;

    }
}
