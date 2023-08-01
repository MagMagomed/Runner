using HyperCasual.Core;
using HyperCasual.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ������� �����������, ����� ����� �������� ������ ���������� �������������� �������
/// </summary>
[CreateAssetMenu(fileName = nameof(ImproveBackpakEvent),
    menuName = "Runner/" + nameof(ImproveBackpakEvent))]
public class ImproveBackpakEvent : AbstractGameEvent
{
    public override void Reset()
    {
        Debug.Log($"Reset");
    }
}
