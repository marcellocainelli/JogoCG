using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuOptions : MonoBehaviour {
    public bool time;
    public bool menu;

	public void LoadScene(string name)
    {
        if(time)
            Time.timeScale = 1;
        if (time && !menu)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
            SceneManager.LoadScene(name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

	
	
}
