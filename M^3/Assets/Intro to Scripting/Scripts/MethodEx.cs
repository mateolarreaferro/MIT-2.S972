using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodEx : MonoBehaviour
{

    //Write a method called “Sequence” that has a void return type and takes one argument(int length)
    //Initialize the for loop with a variable called “currentCount”, increase by 2 (+= 2), and stop when currentCount is bigger than length
    //Debug.Log(“Sequence has started”) when currentCount is equal to 0
    //Debug.Log(“Sequence has ended”) when currentCount is bigger than length
    //Debug.Log(currentCount) on every iteration of the loop
    //Remember to call the Sequence method on the start method


    // Start is called before the first frame update
    void Start()
    {
        Sequence(10);
    }

    void Sequence(int length)
    {
        for (int currentCount = 0; currentCount <= length; currentCount += 2)
        {
                if (currentCount == 0)
                {
                    Debug.Log("Sequence has started!");
                }

            Debug.Log(currentCount);
            
        }

        Debug.Log("Sequence has ended");

    }
}
