using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeFields : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] int age;
    [SerializeField] float height;
    [SerializeField] bool underAge;


    private void Start()
    {
        Debug.Log("Name: " + name + " | " + "Age: " + age + " | " + "Height: " + height + " | " + "Underage: " + underAge);
    }


}
