using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour    {

    public GameObject AutoBucket;

    public void StartAutoBucket () {
        AutoBucket.SetActive(true);
        GlobalBucket.BucketCount -= GlobalBucketElfs.elfValue;
        GlobalBucketElfs.elfValue *= 1.2f;
        GlobalBucketElfs.turnOffButton = true;
        GlobalBucketElfs.makePerSec += 1;
        GlobalBucketElfs.numberOfElfs += 1;
    }
    
}
