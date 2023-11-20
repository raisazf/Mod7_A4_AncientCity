using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PillarBehavior : MonoBehaviour
{
    //movement axis and movement distance for computing open and closed positions
    public Vector3 movementAxis;
    public float distance;
    public TextMeshProUGUI moveText;

    //open and closed positions of this door
    private Vector3 openPos;
    private Vector3 closedPos;

    //the amount of frames this animation should take
    public float frames;

    public AudioClip movePillar;
    public AudioSource source;

    public bool isPushed = false;

    private void Start()
    {
        //Assume the door starts closed. how would you fix this if you can't make this assumption?
        closedPos = transform.position;
        openPos = closedPos + (movementAxis * distance);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPushed)
        {
            gameObject.BroadcastMessage("OpenStairs");
            moveText.gameObject.SetActive(false);
            source.clip = movePillar;
            source.Play();
            isPushed = true;
        }

    }

    public void OpenStairs()
    {
        //Without Coroutines
        //transform.Translate(movementAxis * distance, Space.World);

        StopAllCoroutines();
        StartCoroutine(MovePillar(transform.position, openPos, 1/frames)); 
    }

    public IEnumerator MovePillar(Vector3 startPosition, Vector3 endPosition, float step)
    {
        for(float i = 0; i <= 1f; i += step)
        {
            Vector3 newPosition = Vector3.Lerp(startPosition, endPosition, i);
            transform.position = newPosition;

            //makes the coroutine pause until the next frame
            yield return null;
        }
    }
}
