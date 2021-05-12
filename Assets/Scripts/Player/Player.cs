using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction<int> CoinCollected;

    private int _coinCount;

    private void Start()
    {
        CoinCollected?.Invoke(_coinCount);
    }

    public void CollectCoin()
    {
        _coinCount++;
        CoinCollected?.Invoke(_coinCount);
    }
}
