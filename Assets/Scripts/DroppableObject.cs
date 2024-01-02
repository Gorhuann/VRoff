using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DroppableObject : XRGrabInteractable
{
    // Tag of the object (e.g., "Key")
    public string objectTag;

    // Reference to the puzzle manager
    public PuzzleManager puzzleManager;

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        // Player picked up the object, do what needs to be done here (disable gravity, etc.)
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);

        // Player released the object
        // Check if the correct drop zone has been reached
        if (puzzleManager != null)
        {
            puzzleManager.CheckObject(this.objectTag);
        }
    }
}
