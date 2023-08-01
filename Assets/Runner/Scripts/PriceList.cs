using HyperCasual.Runner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Стоимость всякого говна
/// </summary>
[CreateAssetMenu(fileName = nameof(PriceList),
    menuName = "Runner/" + nameof(PriceList))]
public class PriceList : ScriptableObject
{
    [SerializeField]
    private int improveBackpackPrice;
    public int ImproveBackpackPrice
    {
        get { return (int)(improveBackpackPrice * 1.5 * SaveManager.Instance.BackpackCapacity); }
    }
}
