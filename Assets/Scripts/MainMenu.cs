using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
	
	}

    public void level1()
    {
        Application.LoadLevel("Main");
    }

    public void level2()
    {
        Application.LoadLevel("Scene2");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
