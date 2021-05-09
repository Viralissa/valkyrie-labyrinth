using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Rightplate : MonoBehaviour
    {
        public bool _rightplate = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_rightplate)
            {
                _rightplate = false;
            }
            else if (_rightplate == false)
            {
                _rightplate = true;
            }
        }
    }
}