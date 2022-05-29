using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StopWatchAllOld : MonoBehaviour
{
    int randomBolig;
    int leastSeconds;
    int randomSeconds;

    public Text currentTimeText; // A text component is attached in the inspector
    private string alarmTypeOld;
    bool stopwatchActive;

    // Start is called before the first frame update
    void Start()
    {
        stopwatchActive = true;
        randomBolig = UnityEngine.Random.Range(1, 25);

        leastSeconds = 30; // A made up number representing the minimum time it takes to handle an alarm
        randomSeconds = UnityEngine.Random.Range(0, 180); // A made up interval representing the maximum time it takes to handle an alarm

        alarmTypeOld = this.gameObject.tag; // Finds the object's tag attached in the inspector and changes it to a string

        if (stopwatchActive)
        {
            leastSeconds += randomSeconds;

            TimeSpan time = TimeSpan.FromSeconds(leastSeconds);

            switch (alarmTypeOld)
            {
                case "demensKald": // Match expressions named after alarms' tag
                    currentTimeText.text = "Demenskald: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "faldAlarm":
                    currentTimeText.text = "Faldalarm: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "forladerRum": 
                    currentTimeText.text = "Forlader rum: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "normalKald": 
                    currentTimeText.text = "Normalkald: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "toiletKald": 
                    currentTimeText.text = "Toiletkald: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                default: 
                    currentTimeText.text = "Ukendt alarm: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
            }
        }
    }
}