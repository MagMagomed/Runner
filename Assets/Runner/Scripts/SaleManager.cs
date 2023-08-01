using HyperCasual.Core;
using HyperCasual.Runner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaleManager : MonoBehaviour
{
    public static SaleManager Instance => s_Instance;
    static SaleManager s_Instance;
    [SerializeField]
    PriceList priceList;
    [SerializeField]
    GenericGameEventListener s_onImpruveBackapackEventListener;
    void Awake()
    {
        if (s_Instance != null && s_Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        s_Instance = this;
    }
    private void Start()
    {
        s_onImpruveBackapackEventListener.Subscribe();
        s_onImpruveBackapackEventListener.EventHandler = ImpruveBackpack;
    }
    private void OnDestroy()
    {
        s_onImpruveBackapackEventListener.Unsubscribe();
    }
    public void ImpruveBackpack() 
    {
        if(s_onImpruveBackapackEventListener.m_Event is ImproveBackpakEvent)
        {
            if( 0 > SaveManager.Instance.Currency - (int)(1.5 * priceList.ImproveBackpackPrice * SaveManager.Instance.BackpackCapacity))
            {
                return;
            }
            SaveManager.Instance.Currency -= (int)(1.5 * priceList.ImproveBackpackPrice * SaveManager.Instance.BackpackCapacity);
            SaveManager.Instance.BackpackCapacity++;
            Debug.Log($"Improved to {SaveManager.Instance.BackpackCapacity} - {SaveManager.Instance.Currency}");
        }
    }
}
