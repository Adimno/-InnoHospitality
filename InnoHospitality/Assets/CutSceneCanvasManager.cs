using UnityEngine;

public class CutSceneCanvasManager : MonoBehaviour
{
    public GameObject WelcomeCanvas;
    public GameObject ExploreRoomCanvas;

    public GameObject LivingRoomCanvas;
    public GameObject TrashCanvas;
    public GameObject KitchAreaCanvas;
    public GameObject BedroomCanvas;
    public GameObject BathRoomCanvas;

    // Assets
    public BoxCollider doorCollider;

    void Start()
    {
        WelcomeCanvas.SetActive(true);
        ExploreRoomCanvas.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        TrashCanvas.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        BedroomCanvas.SetActive(false);
        BathRoomCanvas.SetActive(false);
    }

    public void WelcomeCanvasLogic()
    {
        DisableAllCanvases();
        WelcomeCanvas.SetActive(true);
    }

    public void ExploreRoomCanvasLogic()
    {
        doorCollider.enabled = false;
        DisableAllCanvases();
        ExploreRoomCanvas.SetActive(true);
    }

    public void LivingRoomCanvasLogic()
    {
        DisableAllCanvases();
        LivingRoomCanvas.SetActive(true);
    }

    public void TrashCanvasLogic()
    {
        DisableAllCanvases();
        TrashCanvas.SetActive(true);
    }

    public void KitchAreaCanvasLogic()
    {
        DisableAllCanvases();
        KitchAreaCanvas.SetActive(true);
    }

    public void BedroomCanvasLogic()
    {
        DisableAllCanvases();
        BedroomCanvas.SetActive(true);
    }

    public void BathRoomCanvasLogic()
    {
        DisableAllCanvases();
        BathRoomCanvas.SetActive(true);
    }

    // Utility function to disable all canvases
    private void DisableAllCanvases()
    {
        WelcomeCanvas.SetActive(false);
        ExploreRoomCanvas.SetActive(false);
        LivingRoomCanvas.SetActive(false);
        TrashCanvas.SetActive(false);
        KitchAreaCanvas.SetActive(false);
        BedroomCanvas.SetActive(false);
        BathRoomCanvas.SetActive(false);
    }
}
