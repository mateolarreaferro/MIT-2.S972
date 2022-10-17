using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeClip : MonoBehaviour
{
    [SerializeField] AudioSource _source;
    [SerializeField] AudioClip[] myClips;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        _source.clip = myClips[Random.Range(0, myClips.Length)];
        _source.volume = Random.Range(0, 1f);
        _source.Play();
    }


}
