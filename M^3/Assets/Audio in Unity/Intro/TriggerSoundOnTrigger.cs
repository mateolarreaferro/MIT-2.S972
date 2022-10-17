using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundOnTrigger : MonoBehaviour
{
    [SerializeField] AudioSource _source;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        _source.Play();
    }


}
