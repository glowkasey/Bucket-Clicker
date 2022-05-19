using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBucketmachine : MonoBehaviour {

    public static float BucketCount;
    public GameObject BucketDisplay;
    public float  InternalBucket;

    void Update() { 
        InternalBucket = BucketCount;
        BucketDisplay.GetComponent<Text>().text = "Buckets: " + InternalBucket.ToString("#.##");
        
    }
}
