using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Stopwatch = System.Diagnostics.Stopwatch;

public class Timer : MonoBehaviour
{
    public Text timer;
    public Stopwatch watch;
    public static Timer GetTimer;

    private void Start()
    {
        watch = new Stopwatch();
        watch.Start();
        GetTimer = this;
    }

    private void Update()
    {
        TimeSpan currentTime = watch.Elapsed;
        timer.text = currentTime.ToString();
    }
}
