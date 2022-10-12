using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEx : MonoBehaviour
{
    // Make sure one of the two colliding objects has the bool 'isTrigger' set to true
    // Make sure one of the two colliding objects has a rigidbody

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Aha!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Bye!");
    }

}
