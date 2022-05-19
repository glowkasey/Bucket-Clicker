using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBucketTeleporters : MonoBehaviour {
//this is all the code for displaying how many buckets you have
    public static float BucketCount;
    public GameObject BucketDisplay;
    public float  InternalBucket;

    void Update() { 
        InternalBucket = BucketCount;
        BucketDisplay.GetComponent<Text>().text = "Buckets: " + InternalBucket.ToString("#.##");
        
    }
}

