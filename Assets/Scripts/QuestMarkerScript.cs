using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestMarkerScript : MonoBehaviour
{
    [SerializeField] private Text questText;
    [SerializeField] private int questNum;
    [SerializeField] private string questDesc;

    private void OnTriggerEnter(Collider other)
    {
        questText.text = "Quest " + questNum + ": " + questDesc;
        this.gameObject.SetActive(false);
    }
    
}
