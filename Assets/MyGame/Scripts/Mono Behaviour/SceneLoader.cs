using UnityEngine;
using UnityEngine.SceneManagement; //required to switch between Scenes

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneNow (string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

// Lädt die neuen Szenen, wenn Game over ist, man den 'go again' Button klickt, oder das Spiel gestartet wird.
