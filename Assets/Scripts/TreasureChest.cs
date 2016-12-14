using UnityEngine;
using System.Collections;

public class TreasureChest : MonoBehaviour
{
    public GameObject bazooka;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        var player = collision.gameObject.GetComponentInParent<Player>();
        if (bazooka != null)
        {
            Instantiate(bazooka, transform.position, Quaternion.identity);
        }
    }
}
