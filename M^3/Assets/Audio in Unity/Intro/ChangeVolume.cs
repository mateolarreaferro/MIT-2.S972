using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    [SerializeField] AudioSource _source;
    [SerializeField] AudioClip[] myClips;

    [Range(0, 1)]
    public float myVolume;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _source.clip = myClips[Random.Range(0, myClips.Length)];
        _source.volume = 1f;
        _source.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        _source.volume = myVolume;
    }

}
