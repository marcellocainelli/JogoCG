using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuOptions : MonoBehaviour {
    public bool time;

	public void LoadScene(string name)
    {
        if (time)
            Time.timeScale = 1;
        SceneManager.LoadScene(name);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

	
	
}
