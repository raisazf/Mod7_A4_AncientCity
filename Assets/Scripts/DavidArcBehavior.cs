using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DavidArcBehavior : MonoBehaviour
{
    public Animator anim;
    public TextMeshProUGUI goThroughText;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isMorphed", true);
            goThroughText.gameObject.SetActive(false);
        }
    }


}
