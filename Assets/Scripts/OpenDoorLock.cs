using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenDoorLock : MonoBehaviour
{
    public string boolName = "open";
    private bool isDoorOpen = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Animator component not found on the door GameObject.");
        }
    }

    public void ToggleDoorOpen()
    {
        if (!isDoorOpen)
        {
            Debug.Log("Opening the door!");
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        if (animator != null)
        {
            animator.SetBool(boolName, true);
        }

        isDoorOpen = true;
    }
}
