using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitFire : MonoBehaviour
{

    public GameObject fire1, fire2;
    public bool isFire = false;
    public AudioClip igniteFire;
    public AudioSource source;

    public void OnTriggerEnter(Collider other)
    {
        if (!isFire)
        {
            fire1.SetActive(true); fire2.SetActive(true);
            source.clip = igniteFire;
            source.Play();
            isFire = true;
        }
    }
}
