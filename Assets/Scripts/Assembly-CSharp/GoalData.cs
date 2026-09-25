using System;
using UnityEngine;

[Serializable]
public class GoalData
{
    public GoalType goalType;
    public int fluidType;
    public int count;

    [HideInInspector]
    public int displayedCount;

    [HideInInspector]
    public bool isComplete;

    [HideInInspector]
    public Sprite sprite;
}
