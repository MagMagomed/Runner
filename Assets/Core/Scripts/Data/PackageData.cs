using HyperCasual.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(PackageData),
    menuName = "Runner/" + nameof(PackageData))]
public class PackageData : ScriptableObject
{
    [SerializeField]
    private string name;
}
