using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorOpener : MonoBehaviour
{
    public string boolName = "open";
    private bool isDoorOpen = false;
    private Animator doorRightAnimator;

    private void Start()
    {
        doorRightAnimator = GetComponent<Animator>();
        if (doorRightAnimator == null)
        {
            Debug.LogError("Animator component not found on the exit door GameObject.");
        }
    }

    public void ToggleExitDoorOpen()
    {
        if (!isDoorOpen)
        {
            OpenExitDoor();
        }
    }

    private void OpenExitDoor()
    {
        if (doorRightAnimator != null)
        {
            doorRightAnimator.SetBool(boolName, true);
        }

        isDoorOpen = true;
    }
}
