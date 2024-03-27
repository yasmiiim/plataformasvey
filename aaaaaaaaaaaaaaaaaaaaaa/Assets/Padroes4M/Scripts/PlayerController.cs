using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public void RegisterJump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Apertou o pulo");
        }
    }

    public void RegisterMove(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();
        Debug.Log("moveu:" + direction);
    }
}
