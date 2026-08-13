using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlanetUIManager : MonoBehaviour
{
    public static PlanetUIManager instance;

    public GameObject infoPanel;
    public TMP_Text planetNameText;
    public Image planetImage;

    public Vector3 panelOffset = new Vector3(0f, 0.2f, 0f);

    private Camera mainCamera;

    private void Awake()
    {
        instance = this;
        mainCamera = Camera.main;
        infoPanel.SetActive(false);
    }

    public void ShowPlanetInfo(string planetName, Sprite sprite, Transform planetTransform)
    {
        infoPanel.SetActive(true);

        planetNameText.text = planetName;
        planetImage.sprite = sprite;

        infoPanel.transform.position = planetTransform.position + panelOffset;

        infoPanel.transform.LookAt(mainCamera.transform);
        infoPanel.transform.Rotate(0f, 180f, 0f);
    }

    public void HidePlanetInfo()
    {
        infoPanel.SetActive(false);
    }
}