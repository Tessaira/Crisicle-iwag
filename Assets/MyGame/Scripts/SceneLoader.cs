using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //required to switch between Scenes

public class SceneLoader : MonoBehaviour {


    public void PlayBtn()
    {
        // Load Main Level using earlier defined SceneManagement collection
        SceneManager.LoadScene("MainScene");

    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    


    public void RetryBtn()
    {
        // Load Main level; is its own button in case I want to add scores later on
        SceneManager.LoadScene("MainScene");

    }

}

// Lädt die neuen Szenen, wenn Game over ist, man den 'go again' Button klickt, oder das Spiel gestartet wird.
