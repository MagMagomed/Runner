using HyperCasual.Core;
using System;
using UnityEngine;

namespace HyperCasual.Runner
{
    /// <summary>
    /// This View contains pause menu functionalities
    /// </summary>
    public class PauseMenu : View
    {
        [SerializeField]
        HyperCasualButton m_ContinueButton;

        [SerializeField]
        HyperCasualButton m_QuitButton;

        [SerializeField]
        HyperCasualButton m_PauseShop;

        [SerializeField]
        AbstractGameEvent m_ContinueEvent;

        [SerializeField]
        AbstractGameEvent m_QuitEvent;

        [SerializeField]
        AbstractGameEvent m_PauseShopEvent;


        void OnEnable()
        {
            m_ContinueButton.AddListener(OnContinueClicked);
            m_QuitButton.AddListener(OnQuitClicked);
            m_PauseShop.AddListener(OnPauseShopClicked);
        }

        void OnDisable()
        {
            m_ContinueButton.RemoveListener(OnContinueClicked);
            m_QuitButton.RemoveListener(OnQuitClicked);
            m_PauseShop.RemoveListener(OnPauseShopClicked);
        }
        void OnPauseShopClicked()
        {
            m_PauseShopEvent.Raise();
        }
        void OnContinueClicked()
        {
            m_ContinueEvent.Raise();
        }

        void OnQuitClicked()
        {
            m_QuitEvent.Raise();
        }
    }
}
