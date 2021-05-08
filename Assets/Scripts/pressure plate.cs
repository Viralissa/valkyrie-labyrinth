using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{
    private bool plate = false;

    private void OnTriggerEnter(Collider other)
    {
        if (plate)
        {
            plate = false;
        }
        else if (plate == false)
        {
            plate = true;
        }
    }
}
