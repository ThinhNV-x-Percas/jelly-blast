using System;
using TMPro;
using UnityEngine;

public class TextPopEffect : MonoBehaviour
{
    private TextMeshProUGUI _text;

    public float letterDelay = 0.05f;
    public float jumpHeight = 10f;

    private float transitionStartTime;

    public float scaleDamping = 6f;
    public float scaleFrequency = 12f;
    public float bounceDamping = 3f;
    public float bounceFrequency = 8f;
    public bool show;

    private Vector3[][] cachedVertexPositions;

    private TextMeshProUGUI text
    {
        get
        {
            if (!_text)
            {
                _text = GetComponent<TextMeshProUGUI>();
            }
            return _text;
        }
    }

    private void OnEnable()
    {
        text.OnPreRenderText += OnPreRenderText;
    }

    private void OnDisable()
    {
        text.OnPreRenderText -= OnPreRenderText;
    }

    private void CacheVertexPositions(TMP_TextInfo textInfo)
    {
        TMP_MeshInfo[] meshInfo = textInfo.meshInfo;
        cachedVertexPositions = new Vector3[meshInfo.Length][];
        for (int i = 0; i < meshInfo.Length; i++)
        {
            Vector3[] vertices = meshInfo[i].vertices;
            cachedVertexPositions[i] = new Vector3[vertices.Length];
            Array.Copy(vertices, cachedVertexPositions[i], vertices.Length);
        }
    }

    private void OnPreRenderText(TMP_TextInfo textInfo)
    {
        if (textInfo.characterCount < 1)
        {
            return;
        }
    }

    public void StartTransition()
    {
        show = true;
        transitionStartTime = Time.time;
        text.ForceMeshUpdate(false, false);
        CacheVertexPositions(text.textInfo);
        Update();
    }

    private void Update()
    {
        if (!show || cachedVertexPositions == null)
        {
            return;
        }

        text.ForceMeshUpdate(false, false);
        TMP_TextInfo textInfo = text.textInfo;
        float time = Time.time;
        int visibleIndex = 0;

        for (int charIndex = 0; charIndex < textInfo.characterCount; charIndex++)
        {
            TMP_CharacterInfo characterInfo = textInfo.characterInfo[charIndex];
            if (!characterInfo.isVisible)
            {
                continue;
            }

            int materialIndex = characterInfo.materialReferenceIndex;
            int vertexIndex = characterInfo.vertexIndex;
            float elapsed = time - (transitionStartTime + letterDelay * visibleIndex);
            visibleIndex++;

            // Damped spring from 0 to 1.
            float scale = 0f;
            if (elapsed >= 0f)
            {
                float scaleAngle = elapsed * scaleFrequency;
                scale = 1f - Mathf.Exp(-scaleDamping * elapsed) * (Mathf.Cos(scaleAngle) + scaleDamping / scaleFrequency * Mathf.Sin(scaleAngle));
            }

            if (materialIndex >= cachedVertexPositions.Length)
            {
                continue;
            }

            Vector3[] source = cachedVertexPositions[materialIndex];
            if (source.Length < vertexIndex + 4)
            {
                continue;
            }

            Vector3 midpoint = (source[vertexIndex] + source[vertexIndex + 1] + source[vertexIndex + 2] + source[vertexIndex + 3]) * 0.25f;
            Vector3[] destination = textInfo.meshInfo[materialIndex].vertices;
            for (int corner = 0; corner < 4; corner++)
            {
                destination[vertexIndex + corner] = midpoint + (source[vertexIndex + corner] - midpoint) * scale;
            }
        }

        for (int meshIndex = 0; meshIndex < textInfo.meshInfo.Length; meshIndex++)
        {
            textInfo.meshInfo[meshIndex].mesh.vertices = textInfo.meshInfo[meshIndex].vertices;
            text.UpdateGeometry(textInfo.meshInfo[meshIndex].mesh, meshIndex);
        }
    }
}
