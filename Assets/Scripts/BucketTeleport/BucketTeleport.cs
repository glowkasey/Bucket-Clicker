using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketTeleport : MonoBehaviour {

    public bool CreatingBucket = false;
    //this is the amount of buckets the teleporter adds
    public static int BucketIncrease = 50;
    //this is how much its increasing buy for the amount of teleporters
    public int InternalIncrease;

    void Update()   {
        //this is what starts the teleporters 
        BucketIncrease = GlobalTeleport.makePerSec;
        InternalIncrease = BucketIncrease;
        if (CreatingBucket == false) {
            CreatingBucket = true;
            StartCoroutine(CreateTheBucket());
        }
        
    }
    //this is how long it takes between it making buckets and the amount its making per yield return
    IEnumerator CreateTheBucket () {
        GlobalBucket.BucketCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingBucket = false; 
    }
}
