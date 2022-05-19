using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//this is the code for the start button
public class ButtonUI : MonoBehaviour {

    [SerializeField] private string TheGame = "TheGame";

    public void StartButton() {
        SceneManager.LoadScene(TheGame);
    }
}
