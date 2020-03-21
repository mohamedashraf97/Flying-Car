using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class QuitOnEscape : MonoBehaviour
{

    private int text;
    public static bool endGame;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            EndGame.EndText.text = "Thank You Blind :)";
            Application.Quit(3);
        }

    }
}
