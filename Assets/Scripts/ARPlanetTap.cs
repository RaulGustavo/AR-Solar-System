using UnityEngine;

public class ARPlanetTap : MonoBehaviour
{
    [SerializeField] private Camera arCamera;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = arCamera.ScreenPointToRay(touch.position);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                PlanetInfo info = hit.collider.GetComponent<PlanetInfo>();

                if (info != null)
                {
                    PlanetUIManager.instance.ShowPlanetInfo(
                        info.planetName,
                        info.planetSprite,
                        info.transform
                    );
                }
            }
        }
    }
}