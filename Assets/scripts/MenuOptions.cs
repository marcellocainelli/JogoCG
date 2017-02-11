using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuOptions : MonoBehaviour {
    public bool time;

	public void LoadScene(string name)
    {

        if (time)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
        else
            SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

	
	
}
