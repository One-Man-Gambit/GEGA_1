using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        QuestManager.questManager.questItemFound = true;
        Destroy(this.gameObject);
    }
}
