using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Win : MonoBehaviour
    {
        [SerializeField] private Inventory _inventory;
        [SerializeField] private Timer _timer;
        [SerializeField] private GameObject _win;
        [SerializeField] private Text txt;

        private void OnTriggerEnter(Collider other)
        {
            Score();
            Time.timeScale = 0f;
            _win.SetActive(true);
        }

        void Score()
        {
            var score = Mathf.Round((_inventory.present * 10) + (_timer._timer));
            txt.text =  score.ToString();
        }
    }
}