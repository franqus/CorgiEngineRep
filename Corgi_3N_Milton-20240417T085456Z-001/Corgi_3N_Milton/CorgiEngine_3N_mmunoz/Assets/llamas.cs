using UnityEngine;

public class LlamaMovement : MonoBehaviour
{
    public float amplitud = 0.5f; // Amplitud del movimiento de las llamas
    public float velocidad = 1.0f; // Velocidad de oscilación de las llamas
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Movimiento sinusoidal para simular las llamas
        float offsetY = amplitud * Mathf.Sin(Time.time * velocidad);
        transform.position = initialPosition + new Vector3(0, offsetY, 0);
    }
}
