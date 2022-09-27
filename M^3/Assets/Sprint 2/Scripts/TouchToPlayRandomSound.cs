///Part of Making Music in the Metaverse
///Place this script on a game object with an audio source component,
///and a collider with "is trigger" checked.
///Connect any gameobject with a collider and rigidbody as "touchWithThis"
///For example, a primitive shape like a cube as a child of a player's hand.
///This script also uses Unity Events, which you can use if you'd like to do
///anything a little fancier in your scene.
///Contact asimonso@mit.edu or mlarrea@berklee.edu with questions
///Last edited September 2022

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;//lets us use Events

public class TouchToPlayRandomSound : MonoBehaviour
{
    public GameObject [] touchWithThis;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public UnityEvent onTouch;

    // Start is called before the first frame update
    void Start()
    {
        if (audioSource == null)
        {//if no audio source has been connected in the inspector
            audioSource = gameObject.GetComponent<AudioSource>();//then try to find one on the same gameobject as this script
        }

        if (onTouch == null)
        {
            onTouch = new UnityEvent();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < touchWithThis.Length; i++)//Checks if it is any of the 'touchWithThis' GameObjects
        {
            if (other.gameObject == touchWithThis[i])
            {

                    audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
                    audioSource.Play();
                    onTouch.Invoke();
            }

        }
       
    }
}