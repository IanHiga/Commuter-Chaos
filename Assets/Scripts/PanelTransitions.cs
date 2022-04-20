using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelTransitions : MonoBehaviour
{
	public GameObject Panel;

	void Start()
	{
		Disable_Movement();
	}
	
	public void Disable_Movement()
	{
		Time.timeScale = 0;
	}

	public void Enable_Movement()
	{
		Time.timeScale = 1;
	}

	public void HidePanel()
	{
		Enable_Movement();
		Panel.gameObject.SetActive(false);
	}
}
