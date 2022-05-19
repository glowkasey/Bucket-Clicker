using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMachine : MonoBehaviour   {

    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentBuckets;
    public static float machineValue = 100.0f;
    public static bool turnOffButton = false;
    public GameObject machineStats;
    public static int numberOfMachine;
    public static int makePerSec;

    
    void Update()   {
        currentBuckets = GlobalBucket.BucketCount;
        machineStats.GetComponent<Text>().text = "Machine: " + numberOfMachine + " @ " + makePerSec + "Per Second";
        fakeText.GetComponent<Text>().text = "Buy BucketMachine - $" + machineValue;
        realText.GetComponent<Text>().text = "Buy BucketMachine - $" + machineValue;
        if (currentBuckets >= machineValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentBuckets < machineValue) {
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
