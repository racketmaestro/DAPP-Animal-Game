using UnityEngine;

public class PuzzleCompletionChecker : MonoBehaviour
{
    public GameObject[] puzzlePieces; // Array of all puzzle pieces
    public GameObject[] targets; // Array of all targets
    public float delay = 3f; // Delay in seconds before deactivating puzzle pieces
    public GameObject puzzlePiecesParent;   
    private bool allPiecesSnapped = false;

    private void Update()
    {
        // Check if all puzzle pieces are snapped to their respective targets
        if (!allPiecesSnapped)
        {
            bool allSnapped = true;
            for (int i = 0; i < puzzlePieces.Length; i++)
            {
                if (!puzzlePieces[i].GetComponent<DragandDrop>().IsSnappedToTarget(targets[i]))
                {
                    allSnapped = false;
                    break;
                }
            }

            if (allSnapped)
            {
                allPiecesSnapped = true;
                Invoke("DeactivatePuzzlePieces", delay);
            }
        }
    }

    private void DeactivatePuzzlePieces()
    {
        // Set all puzzle pieces inactive
        puzzlePiecesParent.SetActive(false);
    }
}
