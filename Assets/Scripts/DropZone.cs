using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropZone : MonoBehaviour
{
    public string expectedObjectTag;
    public PuzzleManager puzzleManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(expectedObjectTag))
        {
            Debug.Log("Correct object entered drop zone: " + expectedObjectTag);
            puzzleManager.PuzzleSolved(expectedObjectTag);
        }
        else
        {
            Debug.LogWarning("Incorrect object entered drop zone. Expected: " + expectedObjectTag + ", Actual: " + other.tag);
            // You may want to trigger some negative feedback or take specific actions for an incorrect placement
        }
    }
}

