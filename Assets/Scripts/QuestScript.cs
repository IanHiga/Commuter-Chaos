using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour
{
    [SerializeField] private int questNum;
    [SerializeField] private string questDesc;
    [SerializeField] private GameObject startObject;
    [SerializeField] private GameObject goalObject;
    private QuestManager questMgr;
    private Text questText;
    private bool questFinished = false;

    void Start()
    {
        questMgr = GameObject.FindWithTag("QuestManager").GetComponent<QuestManager>();
        questText = questMgr.GetQuestDescText();
    }
    
    public void ActivateQuest()
    {
        startObject.SetActive(false);
        goalObject.SetActive(true);
        questText.text = "Quest " + questNum + ": " + questDesc;
        questMgr.ActivateQuest(questNum);
    }
    
    public void ResetQuest()
    {
        startObject.SetActive(true);
        goalObject.SetActive(false);
    }

    public void FinishQuest()
    {
        goalObject.SetActive(false);
        questFinished = true;
        questMgr.DeactivateQuest();
        questMgr.UpdateNumCompleted();
    }

    public bool IsQuestFinished()
    {
        return questFinished;
    }
}
