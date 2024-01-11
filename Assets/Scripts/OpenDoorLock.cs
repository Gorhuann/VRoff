using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenDoorLock : MonoBehaviour
{
    public string boolName = "Open";
    private bool isDoorOpen = false;
    private Animator frameDoor2;

    private void Start()
    {
        frameDoor2 = GetComponent<Animator>();
        if (frameDoor2 == null)
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
        if (frameDoor2 != null)
        {
            frameDoor2.SetBool(boolName, true);
        }

        isDoorOpen = true;
    }
}
