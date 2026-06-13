using UnityEngine;

namespace Player
{
    public class ColisionesPlayer : MonoBehaviour
    {
        // Este script se encarga de detectar las colisiones y triggers del jugador
        // y mostrar un mensaje en la consola con el nombre del objeto con el que colisiona o triggera.

        // Collision
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Colision con: " + collision.gameObject.name);
        }

        // Trigger
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Trigger con: " + collision.gameObject.name);
        }
    }
}
