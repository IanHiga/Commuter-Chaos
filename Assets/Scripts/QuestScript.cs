using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour
{
    private enum QuestType {Goal, Path};

    [SerializeField] private QuestType type;
    [SerializeField] private int questNum;
    [SerializeField] private string questDesc;
    [SerializeField] private GameObject startObject;
    [SerializeField] private GameObject goalObject;
    [SerializeField] private GameObject[] pathObjects;
    private QuestManager questMgr;
    private Text questText;
    private int numWaypoints;
    private bool questFinished = false;

    void Start()
    {
        questMgr = GameObject.FindWithTag("QuestManager").GetComponent<QuestManager>();
        questText = questMgr.GetQuestDescText();
    }
    
    public void ActivateQuest()
    {
        if (type == QuestType.Path)
        {
            startObject.SetActive(false);
            pathObjects[0].SetActive(true);
            numWaypoints = 0;
            questText.text = "Quest " + questNum + ": " + questDesc + " " + numWaypoints + "/" + pathObjects.Length;
        }
        else
        {
            startObject.SetActive(false);
            goalObject.SetActive(true);
            questText.text = "Quest " + questNum + ": " + questDesc;
        }

        questMgr.ActivateQuest(questNum);
    }
    
    public void ResetQuest()
    {
        if (type == QuestType.Path)
        {
            startObject.SetActive(true);
            goalObject.SetActive(false);
            foreach (GameObject waypoint in pathObjects)
            {
                waypoint.SetActive(false);
            }
        }
        else
        {
            startObject.SetActive(true);
            goalObject.SetActive(false);
        }

    }

    public void FinishQuest()
    {
        goalObject.SetActive(false);
        questFinished = true;
        questMgr.DeactivateQuest();
        questMgr.UpdateNumCompleted();
    }

    public void GetWaypoint()
    {
        pathObjects[numWaypoints].SetActive(false);
        numWaypoints++;
        if (numWaypoints < pathObjects.Length)
        {
            pathObjects[numWaypoints].SetActive(true);
            questText.text = "Quest " + questNum + ": " + questDesc + " " + numWaypoints + "/" + pathObjects.Length;
        }
        else
        {
            questText.text = "Quest " + questNum + ": " + questDesc + " " + numWaypoints + "/" + pathObjects.Length;
            goalObject.SetActive(true);
        }
    }

    public bool IsQuestFinished()
    {
        return questFinished;
    }
}
