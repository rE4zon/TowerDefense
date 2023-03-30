using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    [SerializeField] private InputController InputController;

    private void Awake()
    {
        InputController.Clicked += CheckPlacable;
    }

    private void CheckPlacable(GameObject clickable)
    {
        Tile tile;
        if (clickable.TryGetComponent<Tile>(out tile))
        {
            Debug.Log("Tile Clicked");
        }
    }
}
