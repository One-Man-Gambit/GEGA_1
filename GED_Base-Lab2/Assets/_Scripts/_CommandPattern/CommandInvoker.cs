using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    PlayerAction inputActions;

    void Start() 
    {
        inputActions = PlayerManager.instance.pc.inputAction;
        inputActions.Editor.IncreaseNum.performed += cntxt => Debug.Log("IncreaseNum Pressed!");
    }
}
