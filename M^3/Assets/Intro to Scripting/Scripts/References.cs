using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class References : MonoBehaviour
{

    // Things we are going to reference

    public GameObject myObject;
    public AudioSource mySource;
    public TrailRenderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myObject = GetComponent<GameObject>();

        mySource = GetComponent<AudioSource>();
        mySource.Play();

        myRenderer = GetComponent<TrailRenderer>();
    }

}
