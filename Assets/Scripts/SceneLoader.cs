using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is the code for the quit button
public class SceneLoader : MonoBehaviour {
   public void QuitGame() {
       Application.Quit();
       Debug.Log("Quit!");
   }
}
