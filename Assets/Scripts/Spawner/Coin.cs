using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : SpawnObject
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.CollectCoin();
        }

        Destroy(gameObject);
    }
}
