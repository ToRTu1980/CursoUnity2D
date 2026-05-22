using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El transform de tu personaje
    public float smoothSpeed = 0.125f; // Velocidad de suavizado
    public Vector3 offset; // Desplazamiento opcional de la cámara

    // Límites de la sala actual (puedes cambiarlos al pasar de una imagen a otra)
    public float minX, maxX;
    public float minY, maxY;

    void LateUpdate()
    {
        if (target != null)
        {
            // Posición deseada de la cámara
            Vector3 desiredPosition = target.position + offset;

            // Aplicar límites
            desiredPosition.x = Mathf.Clamp(desiredPosition.x, minX, maxX);
            desiredPosition.y = Mathf.Clamp(desiredPosition.y, minY, maxY);

            // Suavizado del movimiento
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Actualizar posición de la cámara
            transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
        }
    }
}
