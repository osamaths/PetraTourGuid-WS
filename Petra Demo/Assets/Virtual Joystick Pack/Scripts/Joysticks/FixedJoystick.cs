using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick : Joystick
{
    Vector2 joystickPosition = Vector2.zero;
    private Camera cam = new Camera();
    PlayerMovement playerMovement;

    void Start()
    {
        joystickPosition = RectTransformUtility.WorldToScreenPoint(cam, background.position);
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Vector2 direction = eventData.position - joystickPosition;
        inputVector = (direction.magnitude > background.sizeDelta.x / 2f) ? direction.normalized : direction / (background.sizeDelta.x / 2f);
        ClampJoystick();
        handle.anchoredPosition = (inputVector * background.sizeDelta.x / 2f) * handleLimit;

        // Control Player Movements
        if (gameObject.tag == "JMove")
        {
            playerMovement.MoveForawrd(handle.anchoredPosition.y);
            playerMovement.MoveSide(handle.anchoredPosition.x);
        } else {
            playerMovement.Rotate(handle.anchoredPosition.x);
        }

        //if (handle.anchoredPosition.y > 5)
        //    playerMovement.anim.SetBool("isForward", true);
        //if (handle.anchoredPosition.y < -5)
        //    playerMovement.anim.SetBool("isBackward", true);

        //if (handle.anchoredPosition.x > 5)
        //    playerMovement.anim.SetBool("isRight", true);
        //if (handle.anchoredPosition.x < -5)
        //    playerMovement.anim.SetBool("isLeft", true);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {

        

        OnDrag(eventData);
        print(handle.anchoredPosition);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        playerMovement.anim.SetFloat("speed", 0);
        playerMovement.anim.SetFloat("horizontal", 0);

        inputVector = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }
}