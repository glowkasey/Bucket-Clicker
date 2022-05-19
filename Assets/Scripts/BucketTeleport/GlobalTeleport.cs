using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this is the code to make the buttons work they switch between a button that does something and one that dosn't
public class GlobalTeleport : MonoBehaviour   {
    //these are just the gameobjects i use and static inputs
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public float currentBuckets;
    public static float TeleportValue = 1000.0f;
    public static bool turnOffButton = false;
    public GameObject TeleportStats;
    public static int numberOfTeleporters;
    public static int makePerSec;

    
    void Update()   {
        currentBuckets = GlobalBucket.BucketCount;
        //this is how the stats are displayed such as how many teleporters you have and how much they are making persec
        TeleportStats.GetComponent<Text>().text = "Teleporter: " + numberOfTeleporters + " @ " + makePerSec + "Per Second";
        fakeText.GetComponent<Text>().text = "Buy BucketTeleporter - $" + TeleportValue;
        realText.GetComponent<Text>().text = "Buy BucketTeleporter - $" + TeleportValue;
        //this code is what switches between the fake button and the real button
        if (currentBuckets >= TeleportValue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (currentBuckets < TeleportValue) {
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
