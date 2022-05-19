using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLogMachine : MonoBehaviour    {

    public GameObject AutoBucketMachine;

    public void StartAutoMachine () {
        AutoBucketMachine.SetActive(true);
        GlobalBucket.BucketCount -= GlobalMachine.machineValue;
        GlobalMachine.machineValue *= 1.3f;
        GlobalMachine.turnOffButton = true;
        GlobalMachine.makePerSec += 5;
        GlobalMachine.numberOfMachine += 1;
    }
    
}
