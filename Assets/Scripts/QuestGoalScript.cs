using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.GetComponentInParent<QuestScript>().FinishQuest();
    }
}
