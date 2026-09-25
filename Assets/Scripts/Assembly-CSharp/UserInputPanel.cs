using UnityEngine;
using UnityEngine.EventSystems;

public class UserInputPanel : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Singleton<GameManager>.Instance.OnClickUserInputPanel(eventData.position);
    }
}
