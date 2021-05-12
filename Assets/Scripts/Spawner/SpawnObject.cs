using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    [SerializeField] private SpawnLayer _layer;
    [SerializeField] private int _chance;

    public SpawnLayer Layer => _layer;
    public int Chance => _chance;

    private void OnValidate()
    {
        _chance = Mathf.Clamp(_chance, 1, 100);
    }
}
