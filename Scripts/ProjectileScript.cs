using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Portal")
        {
            {
                Transform tp = collision.gameObject.transform;
                player.transform.position = tp.position;
                Destroy(gameObject);
            }
        }
    }
}