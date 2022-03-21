using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
	public void Switch_to_Game()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void Switch_to_Pause()
	{
		SceneManager.LoadScene("PauseMenu");
	}

	public void Switch_to_Main_Menu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}