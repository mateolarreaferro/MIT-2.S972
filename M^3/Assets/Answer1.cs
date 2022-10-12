using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer1 : MonoBehaviour
{
    // write a program that instantiates 10 objects in different positions
    //use for loop
    //Name each object based on the number of iteration in the loop(e.g.copy 1, copy 2, etc.)


    [SerializeField] GameObject originalModel;
    int numberOfCopies = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfCopies; i++)
        {
            float posX = Random.Range(-10, 20);
            float posY = Random.Range(-10, 20);
            float posZ = Random.Range(-10, 20);

            GameObject copy = Instantiate(originalModel, new Vector3(posX, posY, posZ), Quaternion.identity);
            copy.name = i.ToString();
        }
        
    }
}
