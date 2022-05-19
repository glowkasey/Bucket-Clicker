using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLogTeleporter : MonoBehaviour    {

    public GameObject AutoBucketTeleporter;

    public void StartAutoTeleport () {
        AutoBucketTeleporter.SetActive(true);
        //this is what takes away buckets when you buy something
        GlobalBucket.BucketCount -= GlobalTeleport.TeleportValue;
        //this increases how much it costs to buy another teleporter everytime you buy one
        GlobalTeleport.TeleportValue *= 1.4f;
        GlobalTeleport.turnOffButton = true;
        //this determines how much each teleporter produces
        GlobalTeleport.makePerSec += 50;
        //this determines how many teleporters you have
        GlobalTeleport.numberOfTeleporters += 1;
    }
    
}
