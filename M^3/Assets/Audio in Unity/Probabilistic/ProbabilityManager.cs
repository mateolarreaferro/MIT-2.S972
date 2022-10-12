using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProbabilityManager : MonoBehaviour
{
    [SerializeField] GameObject sampleObject;
    [SerializeField] int objectsInScene = 0;
    [SerializeField] GameObject[] objectsReference;
    int maxNumberOfObjects = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewObject()
    {
        if (objectsInScene < maxNumberOfObjects)
        {
            // Create Object
            objectsInScene++;
            GameObject newObject = Instantiate(sampleObject);
            newObject.name = (objectsInScene).ToString();
            UpdateObjectReference(objectsInScene);
        }
        else
        {
            Debug.Log("You've reached the max number of objects per scene");
        }
    }

    void UpdateObjectReference(int count)
    {
        if (count != 0)
        {
            for (int i = 0; i < count; i++)
            {
                objectsReference[i] = GameObject.Find(i.ToString());
            }
        }
    }
}
