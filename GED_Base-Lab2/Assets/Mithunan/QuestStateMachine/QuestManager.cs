using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public static QuestManager questManager;

    public bool questActive = false;
    public bool questComplete = false;
    public bool questItemFound = false;
    public bool instantiated = false;
    public GameObject questItem;
    public Transform questItemPos;

    private void Awake()
    {
        if (questManager != null && questManager != this)
        {
            Destroy(this);
        }
        else
        {
            questManager = this;
        }
            
    }

    private void Update()
    {
        if(questActive == true && instantiated == false)
        {
            Instantiate(questItem);
            instantiated = true;
        }
    }
}
