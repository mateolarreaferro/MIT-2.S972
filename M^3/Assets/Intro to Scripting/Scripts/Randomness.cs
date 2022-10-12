using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomness : MonoBehaviour
{
    public string[] names; // line 25

    // Start is called before the first frame update
    void Start()
    {
        // Generating one random value - Random.Range(min, max)
        float x = Random.Range(10f, 100f);
        Debug.Log(x);

        // Generating a random position
        float xPos = Random.Range(0, 100f);
        float yPos = Random.Range(0, 100f);
        float zPos = Random.Range(0, 100f);

        Vector3 newPosition = new Vector3(xPos, yPos, zPos);
        Debug.Log(newPosition);


        // Selecting a random item of an array
        string selectedString = names[Random.Range(0, names.Length)];
        Debug.Log(selectedString);


    }
}
