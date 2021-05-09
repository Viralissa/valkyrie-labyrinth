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
    }
}