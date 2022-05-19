using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketClickMachine : MonoBehaviour   {
    public GameObject textBox;

    public void ClickTheButton () {
        GlobalBucket.BucketCount += 1;
    }

}
