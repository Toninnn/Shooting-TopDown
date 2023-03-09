using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string sceneName;

    // Start is called before the first frame update
    public void onPlay()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void osExitGame()
    {
        Application.Quit();
    }
}
