using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SecondaryImageColor : BaseMeshEffect
{
    [SerializeField]
    private Color secondaryColor;

    public Color SecondaryColor
    {
        get => secondaryColor;
        set
        {
            secondaryColor = value;
            if (graphic != null)
                graphic.SetVerticesDirty();
        }
    }

    public override void ModifyMesh(VertexHelper vh)
    {
        if (!IsActive())
            return;

        var vertices = new List<UIVertex>();
        vh.GetUIVertexStream(vertices);
        for (int i = 0; i < vertices.Count; i++)
        {
            UIVertex vertex = vertices[i];
            vertex.uv2 = secondaryColor;
            vertices[i] = vertex;
        }
        vh.Clear();
        vh.AddUIVertexTriangleStream(vertices);
    }
}
