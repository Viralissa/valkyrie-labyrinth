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
        void Update()
        {
            if (_rightplate) { ChangeColorRed(); }
            else gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }
        void ChangeColorRed()
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        }
    }
}