using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodsInUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Method/Function is called
        AddNumbers(2, 5); // we have selected 2 and 5 as the even and odd numbers - it could be any integer!

        int x = 32;
        int y = 3;

        AddNumbers(x, y); // we are now inputting these two variables as arguments
        
    }


    int AddNumbers(int evenNumber, int oddNumber)
    {
        return evenNumber + oddNumber;
    }
}
