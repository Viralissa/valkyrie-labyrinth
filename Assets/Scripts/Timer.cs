using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Timer : MonoBehaviour
    {
        public float _timer = 60;
        public Text _timerText;
        [SerializeField] private GameObject _death;

        public void Start()
        {
            _timerText.text = _timer.ToString("F2");
        }

        public void Update()
        {
            _timer -= Time.deltaTime;
            _timerText.text = _timer.ToString("F2");
            if (_timer < 0) { Time.timeScale = 0f; ; _death.SetActive(true); }
        }
    }
}