using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string levelSelect;
    public bool isPause;
    public GameObject pauseMenuCanvas;

	
	
	// Update is called once per frame
	void Update () {
        if (isPause)
        {
            pauseMenuCanvas.SetActive(true);
        }
        else
            pauseMenuCanvas.SetActive(false);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
        }
	}

    public void Resume()
    {
        isPause = false;
    }

    public void LevelSelect()
    {
        Application.LoadLevel(levelSelect);
    }

    public void Quit()
    {
        Application.LoadLevel("AnaMenu");
    }

}
