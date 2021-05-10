using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class LeftPlate : MonoBehaviour
    {
        public bool _leftplate = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_leftplate)
            {
                _leftplate = false;
            }
            else if (_leftplate == false)
            {
                _leftplate = true;
            }
        }
        void Update()
        {
            if (_leftplate) { ChangeColor(); }
            else gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }
        void ChangeColor()
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        }
    }
}