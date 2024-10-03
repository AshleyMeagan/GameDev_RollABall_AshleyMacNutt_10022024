using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Make sure to include this for TextMeshPro

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Reference to the TextMeshProUGUI component
    private float startTime;
    private bool finished = false;

    void Start()
    {
        // Initialize the timer with the starting time
        startTime = Time.time;
    }

    void Update()
    {
        if (finished)
            return;

        // Calculate elapsed time
        float t = Time.time - startTime;

        // Format the time as minutes and seconds
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        // Update the timer UI text
        timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finished = true;
    }
}