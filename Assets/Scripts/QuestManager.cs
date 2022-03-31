using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private GameObject[] questObjects;
    [SerializeField] private Text questText;
    private int curQuestNum;

    private void Start()
    {
        curQuestNum = 0;
    }

    public void ActivateQuest(int numQuest)
    {
        int i = 0;
        foreach (GameObject temp in questObjects)
        {
            if ((i != numQuest - 1) && (!temp.GetComponent<QuestScript>().IsQuestFinished()))
            {
                temp.SetActive(false);   
            }
            i++;
        }

        if (curQuestNum == 0)
        {
            curQuestNum = numQuest;
        }
    }

    public void DeactivateQuest()
    {
        foreach (GameObject temp in questObjects)
        {
            if (!temp.GetComponent<QuestScript>().IsQuestFinished())
            {
                temp.SetActive(true);
            }
        }

        if (curQuestNum != 0)
        {
            if (!questObjects[curQuestNum - 1].GetComponent<QuestScript>().IsQuestFinished())
            {
                questObjects[curQuestNum - 1].GetComponent<QuestScript>().ResetQuest(); 
            }
            questText.text = "Find a new quest!";
            curQuestNum = 0;
        }
    }

    public Text GetQuestDescText()
    {
        return questText;
    }
}
