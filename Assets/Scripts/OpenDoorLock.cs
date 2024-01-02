using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenDoorLock : MonoBehaviour
{
    public string boolName = "open";
    private bool isDoorOpen = false;
    private Animator doorRightAnimator;

    private void Start()
    {
        doorRightAnimator = GetComponent<Animator>();
        if (doorRightAnimator == null)
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
        if (doorRightAnimator != null)
        {
            doorRightAnimator.SetBool(boolName, true);
        }

        isDoorOpen = true;
    }
}
