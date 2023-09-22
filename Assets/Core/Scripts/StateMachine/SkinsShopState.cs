using HyperCasual.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsShopState : AbstractState
{
    readonly Action m_onSkinsShopOpen;

    public override string Name => $"{nameof(SkinsShopState)}";

    /// <param name="onPause">The action that is invoked when the game loop paused</param>
    public SkinsShopState(Action onPause)
    {
        m_onSkinsShopOpen = onPause;
    }

    public override void Enter()
    {
        Time.timeScale = 0f;
        m_onSkinsShopOpen?.Invoke();
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
