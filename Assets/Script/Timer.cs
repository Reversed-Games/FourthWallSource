using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    DateTime startTime;

    public Text timer;
    public TimeSpan timeElapsed { get; private set; }

    private void Start()
    {

        startTime = DateTime.Now;
    }

    private void Update()
    {
        this.timeElapsed = DateTime.Now - startTime;
        timer.text = timeElapsed.ToString();
    }
}
