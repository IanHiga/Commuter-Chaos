using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	//need for text
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
	public Text quest_text;

	public void Switch_to_Game()
	{
		SceneManager.LoadScene("GameScene");
	}

	public void Switch_to_Pause()
	{
		//SceneManager.LoadScene("PauseMenu");
		//Revert back to line above for non-additive scene loading of Pause Menu		
		Time.timeScale = 0;
		SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
	}

	public void Switch_to_Main_Menu()
	{
		SceneManager.LoadScene("MainMenu");
		Time.timeScale = 1;	//also need this line in here for going from pause --> main menu
	}
	
	public void Switch_to_Quest_Test_Scene()
	{
		SceneManager.LoadScene("QuestTestScene");
	}
	
	public void Resume_Game()
	{
		SceneManager.UnloadSceneAsync("PauseMenu");
		Time.timeScale = 1;
	}

	//testing text change
	public void Update_Text()
	{
		quest_text.text = "NEW QUEST";
		/*
		if (Input.GetKey(KeyCode.Q))
       		{
			quest_text.text = "NEW QUEST";
        	}
		*/
	}
}