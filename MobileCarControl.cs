using untiyEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystem;

public class MobileCarButton:MonoBehaviour,IpointerDownHandler,IpointerUpHeader;
{
    public InputActionReference action;
    public void OnPointerDown(PointerEventData eventData)
{
    action.action.Enable();
    action.action.Trigger();
}
public void OnPointerUp(PointerEventData eventData)
{
    action.action.Disable()
}
}