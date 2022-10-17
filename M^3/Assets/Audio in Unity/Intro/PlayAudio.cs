using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] AudioSource mySource;

    // Start is called before the first frame update
    void Start()
    {
        mySource = GetComponent<AudioSource>();
        mySource.Play();
    }
}
