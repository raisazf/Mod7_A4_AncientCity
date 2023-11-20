using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotateStatue : MonoBehaviour
{
    public Transform statue;
    public float speed;

    public AudioClip statueRotation;
    public AudioSource source;

    private bool isRotate = false;

    public void Update()
    {
        if (isRotate && statue.transform.rotation.y > 0f)
        {
            source.Play();
        }
    }
    public void FixedUpdate()
    {
        if (isRotate && statue.transform.rotation.y > 0f)
        {
            statue.transform.Rotate(Vector3.down * speed * Time.deltaTime);

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("trigger");

            source.clip = statueRotation;
            isRotate = true;
        }
    }
}
