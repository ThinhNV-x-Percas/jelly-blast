using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : SpecialFluid
{
    public int mergeIndex;

    public Transform upArrow;
    public Transform downArrow;
    public Transform leftArrow;
    public Transform rightArrow;

    public float arrowSpacing = 1f;
    public float arrowZOffset = -1f;

    public Sprite[] sprites;
    public Sprite[] activeSprites;

    public bool isBig;

    public void Init(FluidSolver _solver, int _id, HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _mergeIndex, Material _material, bool _isBig)
    {
        id = _id;
        mergeIndex = _mergeIndex;
        mr.material = _material;
        isBig = _isBig;
        InitArrows();

        if (mergeIndex >= 1)
            StartCoroutine(HandleInAnim());

        base.Init(_solver, _particleIds, _fluidType, _compute);
    }

    public IEnumerator HandleInAnim()
    {
        yield return new WaitForSeconds(0.1f);
    }

    public override void OnPreComputeUpdate()
    {
        base.OnPreComputeUpdate();
        UpdateArrows();
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x, pos.y, id * depthStride - 5f);
    }

    public IEnumerator RotateBlob()
    {
        float startTime = Time.time;
        const float duration = 0.35f;
        float endTime = startTime + duration;

        while (Time.time < endTime)
        {
            float t = (Time.time - startTime) / duration;
            SetRotation((EasingFunction.EaseOutQuad(t) - 1f) * 0.5f);
            yield return null;
        }

        SetRotation(1f);
    }

    private void SetRotation(float rot)
    {
        mr.GetPropertyBlock(_propBlock);
        _propBlock.SetFloat("_Rotation", rot);
        mr.SetPropertyBlock(_propBlock);
    }

    public void InitArrows()
    {
        upArrow.gameObject.SetActive(mergeIndex == 1);
        downArrow.gameObject.SetActive(mergeIndex == 1);
        leftArrow.gameObject.SetActive(mergeIndex < 2);
        rightArrow.gameObject.SetActive(mergeIndex < 2);
    }

    public void Activate()
    {
    }

    public void UpdateArrows()
    {
        UpdateArrowPosition(upArrow, Vector2.up * arrowSpacing);
        UpdateArrowPosition(downArrow, Vector2.down * arrowSpacing);
        UpdateArrowPosition(leftArrow, Vector2.left * arrowSpacing);
        UpdateArrowPosition(rightArrow, Vector2.right * arrowSpacing);

        void UpdateArrowPosition(Transform arrow, Vector2 localPos)
        {
            Transform mrTransform = mr.transform;
            arrow.position = mrTransform.position + Vector3.Scale(localPos, mrTransform.localScale) + Vector3.forward;
        }
    }
}
