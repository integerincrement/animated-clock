using System;
using UnityEngine;

public class Clock : UnityEngine.MonoBehaviour  {

    // one hour on a clock is 30 degrees of rotation
    const float hoursToDegrees = -30f;
    const float minutesToDegrees = -6f;
    const float secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot , minutesPivot, secondsPivot;

    private void Update()    {
        DateTime time = DateTime.Now;

        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * time.Hour);

        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * time.Minute);

        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * time.Second);
    }
}