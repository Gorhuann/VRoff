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
        if (puzzleManager == null)
        {
            Debug.LogError("PuzzleManager n'est pas assigné.");
            return;
        }

        if (other.CompareTag(expectedObjectTag))
        {
            Debug.Log("Objet correct entré dans la zone de dépôt : " + expectedObjectTag);
            puzzleManager.PuzzleSolved(expectedObjectTag);
        }
        else
        {
            Debug.LogWarning("Objet incorrect entré dans la zone de dépôt. Attendu : " + expectedObjectTag + ", Actuel : " + other.tag);
            // Vous pouvez déclencher un retour négatif ou prendre des mesures spécifiques pour un placement incorrect.
        }
    }

}

