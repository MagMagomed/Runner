using HyperCasual.Core;
using HyperCasual.Runner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseShopMenu : View
{
    [SerializeField]
    HyperCasualButton m_AddCapacityButton;
    [SerializeField]
    AbstractGameEvent m_AddCapacityEvent;
    [SerializeField]
    HyperCasualButton m_Play;
    [SerializeField]
    AbstractGameEvent m_PlayEvent;
    [SerializeField]
    HyperCasualButton m_SkinsButton;
    [SerializeField]
    AbstractGameEvent m_GoToSkinsEvent;
    void OnEnable()
    {
        m_AddCapacityButton.AddListener(OnAddCapacityClicked);
        m_Play.AddListener(OnClickPlayButton);
        m_SkinsButton.AddListener(OnClickSkinsButton);
    }
    void OnDisable()
    {
        m_AddCapacityButton.RemoveListener(OnAddCapacityClicked);
        m_Play.RemoveListener(OnClickPlayButton);
    }
    private void OnAddCapacityClicked()
    {
        m_AddCapacityEvent.Raise();
    }
    private void OnClickPlayButton()
    {
        m_PlayEvent.Raise();
    }
    private void OnClickSkinsButton()
    {
        m_GoToSkinsEvent.Raise();
    }
}
