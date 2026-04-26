using System;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        DateTime time = DateTime.Now;

        float seconds = time.Second;
        float minutes = time.Minute + seconds / 60f;
        float hours = time.Hour % 12 + minutes / 60f;

        // Rotasi (Z axis karena 2D)
        secondHand.localRotation = Quaternion.Euler(seconds * 6f, 0, 0);
        minuteHand.localRotation = Quaternion.Euler(minutes * 6f, 0, 0);
        hourHand.localRotation = Quaternion.Euler(hours * 30f, 0, 0);
    }
}