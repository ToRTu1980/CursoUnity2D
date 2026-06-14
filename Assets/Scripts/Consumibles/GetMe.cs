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
                //MovimientoPlayer classMovPlayer = collision.GetComponent<MovimientoPlayer>();
                //classMovPlayer.vida += HongoCuracion;

                //Uso el GameManager para modificar la vida del jugador, asi no tengo que acceder a
                //la clase del movimiento del jugador, y puedo modificar la vida desde cualquier parte del juego.
                GameManager.Instance.vidaPlayer += HongoCuracion;

                Debug.Log("Se ha curado " + HongoCuracion + " de vida. =)");
                Debug.Log("Tienes " + GameManager.Instance.vidaPlayer + " de vida total. <3 ");

                gameObject.SetActive(false);
            }

            // Tambien se puede hacer con el nombre del objeto, pero es mas recomendable usar el tag.
            // if (collision.name == ("GnomeColider"))
        }
    }
}
