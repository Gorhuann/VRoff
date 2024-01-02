using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropZone : XRBaseInteractable
{
    // Tag of the expected object on this drop zone (e.g., "Key")
    public string expectedObjectTag;

    // Reference to the puzzle manager
    public PuzzleManager puzzleManager;

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);

        // Check if the object entering the collision is of the expected type
        if (interactor.selectTarget.CompareTag(expectedObjectTag))
        {
            // The object is correct, you can trigger actions here
            Debug.Log("Correct object dropped on the drop zone!");
            puzzleManager.PuzzleSolved(); // Call the puzzle solved function
        }
    }
}
