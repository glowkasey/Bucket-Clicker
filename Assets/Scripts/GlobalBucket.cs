using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBucket : MonoBehaviour {

    public static float BucketCount;
    public GameObject BucketDisplay;
    public float  InternalBucket;

    //this is what the bucketdisplay uses to know how many buckets you have
    void Update() { 
        InternalBucket = BucketCount;
        BucketDisplay.GetComponent<Text>().text = "Buckets: " + InternalBucket.ToString("#.##");
        
    }
}
