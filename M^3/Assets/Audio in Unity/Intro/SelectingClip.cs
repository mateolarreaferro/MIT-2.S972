using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingClip : MonoBehaviour
{
    [SerializeField] AudioClip[] myClips;
    [SerializeField] AudioSource _source;
    [SerializeField] int desiredSample;
    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _source.clip = myClips[desiredSample];
        _source.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        _source.Stop();
    }

}
