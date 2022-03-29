using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    [SerializeField] private GameObject[] questObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleVisibility(int numQuest)
    {
        int i = 0;
        foreach (GameObject temp in questObjects)
        {
            if (i != numQuest)
            {
                temp.SetActive(false);   
            }
            i++;
        }
    }
}
