using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketElfs : MonoBehaviour {
    
    public bool CreatingBucket = false;
    public static int BucketIncrease = 1;
    public int InternalIncrease;

    void Update()   {
        BucketIncrease = GlobalBucketElfs.makePerSec;
        InternalIncrease = BucketIncrease;
        if (CreatingBucket == false) {
            CreatingBucket = true;
            StartCoroutine(CreateTheBucket());
        }
        
    }

    IEnumerator CreateTheBucket () {
        GlobalBucket.BucketCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingBucket = false; 
    }
}
