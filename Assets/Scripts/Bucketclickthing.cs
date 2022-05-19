using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucketclickthing : MonoBehaviour   {
    public GameObject textBox;

    public void ClickTheButton () {
        //this is just code for the amount of buckets you have
        GlobalBucket.BucketCount += 1;
    }

}
