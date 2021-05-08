using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float _timer = 60;
    public Text _timerText;

    public void Start()
    {
        _timerText.text = _timer.ToString("F2");
    }

    public void Update()
    {
        _timer -= Time.deltaTime;
        _timerText.text = _timer.ToString("F2");
    }
}
