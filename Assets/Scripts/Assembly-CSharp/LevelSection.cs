using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelSection
{
    [Tooltip("World-space Y position of this section’s centre")]
    public float y;

    [Tooltip("Locks that belong to this section (populated automatically in Init)")]
    public List<Lock> locks = new List<Lock>();
}
