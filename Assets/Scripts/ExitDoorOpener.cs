using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorOpener : MonoBehaviour
{
    public string boolName = "Open";
    private bool isDoorOpen = false;
    private Animator frameDoor1;

    private void Start()
    {
        frameDoor1 = GetComponent<Animator>();
        if (frameDoor1 == null)
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
        if (frameDoor1 != null)
        {
            frameDoor1.SetBool(boolName, true);
        }

        isDoorOpen = true;
    }
}
