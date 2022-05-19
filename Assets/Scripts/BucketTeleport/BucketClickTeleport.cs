using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketClickTeleport: MonoBehaviour   {
    public GameObject textBox;

    public void ClickTheButton () {
        GlobalBucket.BucketCount += 1;
    }

}
