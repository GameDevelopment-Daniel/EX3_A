using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class hide_show : MonoBehaviour
{
    bool active=true;
    public void hide__show(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            active = !active;
            SpriteRenderer s = GetComponent<SpriteRenderer>();
            s.enabled = active;
            //this.gameObject.SetActive(active);
            Debug.Log("hey");
        }
    }

    
}
