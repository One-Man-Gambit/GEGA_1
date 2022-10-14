using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCompleteState : NpcBaseState
{
    public override void EnterState(NpcStateManager npc)
    {
        Debug.Log("Entered completer state.");
        npc.GetComponent<Animator>().Play("Yes");
    }

    public override void UpdateState(NpcStateManager npc)
    {
        
    }

    public override void OnCollisionEnter(NpcStateManager npc, Collision collision)
    {

    }
}
