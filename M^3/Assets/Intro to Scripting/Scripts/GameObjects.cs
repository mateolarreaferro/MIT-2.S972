using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjects : MonoBehaviour
{
    [SerializeField] GameObject surpriseObject;

    // Start is called before the first frame update
    void Start()
    {
 
        // Activate

        surpriseObject = GameObject.Find("SphereObject"); // Another Object - finds the object based on name
        surpriseObject.SetActive(true); // Another Object - turns on

        //// Disable

        //surpriseObject = GameObject.Find("SphereObject"); // Another Object - finds the object based on name
        //surpriseObject.SetActive(false); // Another Object - turns off

        //this.gameObject.SetActive(false); // this = object that has this script attached



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
