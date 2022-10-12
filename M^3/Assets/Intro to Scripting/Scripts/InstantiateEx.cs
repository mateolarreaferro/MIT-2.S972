using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEx : MonoBehaviour
{
    [SerializeField] GameObject originalModel;

    // Start is called before the first frame update
    void Start()
    {
        // Basic
        Instantiate(originalModel, transform.position, transform.rotation); // Makes an instance of originalModel and sets
        // its position and rotation based on the GameObject where this script is attached

        // Set Position and Rotation (use Quarternion.identity to keep the values of parent axes)
        Instantiate(originalModel, new Vector3(0, 0, 0), new Quaternion(10, 100, 50, 10));

        // Instantiate in random position
        float X = Random.Range(0, 20f);
        float Y = Random.Range(0, 20f);
        float Z = Random.Range(0, 20f);
        Instantiate(originalModel, new Vector3(X, Y, Z), Quaternion.identity);

        // Instantiate and name new instance
        GameObject copy = Instantiate(originalModel, transform.position, transform.rotation);
        copy.name = "This is the Copy!";


    }
}
