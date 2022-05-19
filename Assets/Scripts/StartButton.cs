using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this is the code for the bucket button that you click to produce your first buckets
public class StartButton : MonoBehaviour {

    public GameObject textBox;

    public void ClickTheButton () {
        textBox.SetActive (true);
    } 

}
