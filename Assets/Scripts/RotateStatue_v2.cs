using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RotateStatue_v2 : MonoBehaviour
{
    public Transform statue;
    public float rotationDuration = 20f;
    public float rotateBy = 90f;
    public TextMeshProUGUI rotateText;

    public AudioClip statueRotation;
    public AudioSource source;

    private bool isRotate = false;
     private float FADE_TIME_SECONDS = 5;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !isRotate)
        {
            Debug.Log("trigger");
            StartCoroutine(RotateObjectCoroutine());

            rotateText.gameObject.SetActive(false);
            source.clip = statueRotation;
            isRotate = true;
            source.Play();
        }
    }

    public IEnumerator RotateObjectCoroutine()
    {
        isRotate = true;

        Quaternion startRotation = statue.transform.rotation;
        Quaternion targetRotation = Quaternion.Euler(statue.transform.eulerAngles + Vector3.up * rotateBy); // Rotate 90 degrees around the Y-axis

        float elapsedTime = 0f;

        while (elapsedTime < rotationDuration)
        {
            statue.transform.rotation = Quaternion.Lerp(startRotation, targetRotation, elapsedTime / rotationDuration);
            elapsedTime += Time.deltaTime;
            source.volume = Mathf.Lerp(1, 0, elapsedTime / FADE_TIME_SECONDS);
            yield return null;
        }

        statue.transform.rotation = targetRotation; // Ensure the rotation is exactly the target rotation
        source.Stop();
        isRotate = false;
    }
}
