using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicAndPrivate : MonoBehaviour
{
    int x; // default is private
    private float y; // private -- will not appear in the inspector
    public double z; // public -- will appear in the inspector
}
