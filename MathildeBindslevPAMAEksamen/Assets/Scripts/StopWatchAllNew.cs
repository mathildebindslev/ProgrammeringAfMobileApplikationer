using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StopWatchAllNew : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText; // A text component is attached in the inspector
    int randomBolig;
    private string alarmType; // NEW: String variable

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        stopwatchActive = true;

        randomBolig = UnityEngine.Random.Range(1, 25);
        alarmType = this.gameObject.tag; // NEW: Finds the object's tag attached in the inspector and changes it to a string
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive) // NEW: '== true' removed 
        {
            currentTime += Time.deltaTime; // NEW: Changed from 'currentTime = currentTime + Time.deltaTime;'

            TimeSpan time = TimeSpan.FromSeconds(currentTime); // Variable that represents a time interval in seconds from the currentTime float

            switch (alarmType) // NEW: Switch statement instead of if statement
            {
                case "demensKald": // Match expressions named after alarms' tag
                    currentTimeText.text = "Demenskald: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "faldAlarm": // Match expressions named after alarms' tag
                    currentTimeText.text = "Faldalarm: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "forladerRum": // Match expressions named after alarms' tag
                    currentTimeText.text = "Forlader rum: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "normalKald": // Match expressions named after alarms' tag
                    currentTimeText.text = "Normalkald: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                case "toiletKald": // Match expressions named after alarms' tag
                    currentTimeText.text = "Toiletkald: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
                default: // Match expressions named after alarms' tag
                    currentTimeText.text = "Ukendt alarm: Bolig " + randomBolig + "\n" + time.ToString(@"mm\:ss");
                    break;
            }
        }
    }

// NEW: Removed from previous script since it is not used
 /* public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    } */
}