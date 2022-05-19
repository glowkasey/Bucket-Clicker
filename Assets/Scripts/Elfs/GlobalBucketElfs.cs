using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBucketElfs : MonoBehaviour   {

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentBuckets;
    public static float elfValue = 20.0f;
    public static bool turnOffButton = false;
    public GameObject elfStats;
    public static int numberOfElfs;
    public static int makePerSec;

    
    void Update()   {
        currentBuckets = GlobalBucket.BucketCount;
        if (numberOfElfs == 100) {
            makePerSec *= 2;
        }
        elfStats.GetComponent<Text>().text = "Elfs: " + numberOfElfs + " @ " + makePerSec + "Per Second";
        fakeText.GetComponent<Text>().text = "Buy BucketElf - $" + elfValue;
        realText.GetComponent<Text>().text = "Buy BucketElf - $" + elfValue;
        if (currentBuckets >= elfValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentBuckets < elfValue) {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
        if (turnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
        
    }
}
