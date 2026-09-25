using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageSliceWithUV : BaseMeshEffect
{
    protected override void Start()
    {
        if (graphic)
            graphic.SetVerticesDirty();
    }

    public override void ModifyMesh(VertexHelper vh)
    {
        if (!IsActive())
            return;

        var vertices = new System.Collections.Generic.List<UIVertex>();
        vh.GetUIVertexStream(vertices);
        if (vertices.Count == 0)
            return;

        Vector2 min = vertices[0].position;
        Vector2 max = min;
        for (int i = 1; i < vertices.Count; i++)
        {
            min = Vector2.Min(min, vertices[i].position);
            max = Vector2.Max(max, vertices[i].position);
        }

        Vector2 size = max - min;
        for (int i = 0; i < vertices.Count; i++)
        {
            UIVertex vertex = vertices[i];
            vertex.uv1 = new Vector4((vertex.position.x - min.x) / size.x, (vertex.position.y - min.y) / size.y, 0f, 0f);
            vertices[i] = vertex;
        }
        vh.Clear();
        vh.AddUIVertexTriangleStream(vertices);
    }
}
