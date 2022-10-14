using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWaitState : NpcBaseState
{
    
    public override void EnterState(NpcStateManager npc)
    {
        Debug.Log("Entered wait state.");
        npc.GetComponent<Animator>().Play("Idle");
    }

    public override void UpdateState(NpcStateManager npc)
    {
        
    }

    public override void OnCollisionEnter(NpcStateManager npc, Collision collision)
    {
        if(QuestManager.questManager.questItemFound)
        {
            npc.SwitchState(npc.CompleteState);
        }
    }
}
