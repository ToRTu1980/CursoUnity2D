using Player;
using UnityEngine;

namespace Consumibles
{
    public class GetMe : MonoBehaviour
    {
        public float HongoCuracion = 10f; // Cantidad de vida que cura el hongo

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // El tag esta en el GnomeColider que esta dentro del Gnome.
            if (collision.CompareTag("Gnome"))
            {
                MovimientoPlayer classPlayer = collision.GetComponent<MovimientoPlayer>();
                classPlayer.vida += HongoCuracion;
                Debug.Log("Se ha curado " + HongoCuracion + " de vida. =)");
                Debug.Log("Tienes " + classPlayer.vida + "de vida total. <3");
                gameObject.SetActive(false);
            }
        }
    }
}
