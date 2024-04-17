using UnityEngine;

public class AspaRotativa : MonoBehaviour
{
    public float velocidadRotacion = 100f; // Velocidad de rotación en grados por segundo
    public Vector3 ejeDeRotacion = Vector3.up; // Eje de rotación

    // Actualizamos el objeto cada frame
    void Update()
    {
        // Rotamos el objeto vacío solo alrededor del eje especificado
        transform.Rotate(ejeDeRotacion, velocidadRotacion * Time.deltaTime);
    }
}
