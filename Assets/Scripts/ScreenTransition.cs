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
		SceneManager.LoadScene("PauseMenu");
	}

	public void Switch_to_Main_Menu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	public void Switch_to_Quest_Test_Scene()
	{
		SceneManager.LoadScene("QuestTestScene");
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