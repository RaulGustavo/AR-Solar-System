using UnityEngine;

public class PlanetBehavior : MonoBehaviour
{
    public Transform sun;
    public float orbitSpeed;
    public float rotationSpeed;

    void Update()
    {
        // Orbit around the sun
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // Spin on its own axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
