using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    public GameObject door;
    private Animator _animator;

    private void Start()
    {
        _animator = door.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            _animator.SetBool("OpenDoor", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        _animator.SetBool("OpenDoor", false);
    }
}
