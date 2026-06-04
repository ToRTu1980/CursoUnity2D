using UnityEngine;

namespace Player
{
    public class ColisionesPlayer : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("Colision con: " + collision.gameObject.name);
        }
    }
}
