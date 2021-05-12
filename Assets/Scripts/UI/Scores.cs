using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scores;

    private void OnEnable()
    {
        _player.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _player.CoinCollected -= OnCoinCollected;
    }

    private void OnCoinCollected(int scores)
    {
        _scores.text = scores.ToString();
    }
}
