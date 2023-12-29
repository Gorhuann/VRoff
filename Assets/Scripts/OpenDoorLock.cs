using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


using UnityEngine;

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

    public void ToggleDoorOpen(string enteredCode, string correctCode)
    {
        if (!isDoorOpen && enteredCode == correctCode)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        // Play the "Open" animation
        if (doorRightAnimator != null)
        {
            doorRightAnimator.SetBool(boolName, true);
        }

        isDoorOpen = true;
    }
}
