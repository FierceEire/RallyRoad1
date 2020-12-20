using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTime : MonoBehaviour
{
    public static int MinuteCounter;
    public static int SecondCounter;
    public static float MillisecondCounter;
    public static string MillicounterDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    void Update()
    {
        MillisecondCounter += Time.deltaTime * 10;
        MillicounterDisplay = MillisecondCounter.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MillicounterDisplay;

        if (MillisecondCounter >= 10)
        {
            MillisecondCounter = 0;
            SecondCounter += 1;
        }

        if (SecondCounter <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCounter + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCounter + ".";
        }
        if (SecondCounter >= 60) {
            SecondCounter = 0;
            MinuteCounter += 1;
        }
        if (MinuteCounter <= 9) {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCounter + ":";
        }
    }
}

