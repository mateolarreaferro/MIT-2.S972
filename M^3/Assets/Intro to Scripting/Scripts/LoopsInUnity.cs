using UnityEngine;
using System.Collections;

public class LoopsInUnity : MonoBehaviour
{
    int thingsToDo = 5;


    void Start()
    {
        // ----------------- WHILE -----------------------------
       //WhileLoopExample();

        // ------------------- FOR ----------------------------
        ForLoopExample();
    }








    void WhileLoopExample()
    {
        while (thingsToDo > 0)
        {
            Debug.Log("Number of things to do: " + thingsToDo);
            thingsToDo--;
        }
        Debug.Log("Done. Bravooooo!"); // Outside of While Loop

    }

    void ForLoopExample()
    {
        for (int i = 0; i <= thingsToDo; i++)
        {
            Debug.Log("I have " + i + " thing(s) to do!");
        }
    }
}