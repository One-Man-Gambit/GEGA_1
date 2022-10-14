using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcHelpState : NpcBaseState
{
    public bool helpFound = false;
    float currentTime = 0f;
    float targetTime = 3f;
    public override void EnterState (NpcStateManager npc)
    {
        Debug.Log("Hello I need help!");
        npc.GetComponent<Animator>().Play("Wave");
    }

    public override void UpdateState (NpcStateManager npc)
    {
        //if(currentTime <= targetTime)
        //{
        //    currentTime += Time.deltaTime;
        //}
        //else
        //{
        //    helpFound = true;
        //}
        //if(helpFound)
        //{
        //    npc.SwitchState(npc.WaitState);
        //}
        //if(QuestManager.questManager.questActive == true)
        //{
        //    npc.SwitchState(npc.WaitState);
        //}
    }

    public override void OnCollisionEnter (NpcStateManager npc, Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.CompareTag("Player"))
        {
            QuestManager.questManager.questActive = true;
            Debug.Log("Quest Started");
            npc.SwitchState(npc.WaitState);
        }
        
    }
}
