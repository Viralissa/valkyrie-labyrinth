using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class CenterPlate : MonoBehaviour
    {
        public bool _centerplate = false;

        private void OnTriggerEnter(Collider other)
        {
            if (_centerplate)
            {
                _centerplate = false;
            }
            else if (_centerplate == false)
            {
                _centerplate = true;
            }
        }
    }
}