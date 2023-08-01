using HyperCasual.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseShopState : AbstractState
{
    readonly Action m_OnPauseShopOpen;

    public override string Name => $"{nameof(PauseShopState)}";

    /// <param name="onPause">The action that is invoked when the game loop paused</param>
    public PauseShopState(Action onPause)
    {
        m_OnPauseShopOpen = onPause;
    }

    public override void Enter()
    {
        Time.timeScale = 0f;
        m_OnPauseShopOpen?.Invoke();
    }
    public override IEnumerator Execute() 
    {
        yield return null;
    }
    public override void Exit()
    {
        Time.timeScale = 1f;
    }
}
