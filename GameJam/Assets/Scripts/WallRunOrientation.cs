using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRunOrientation : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    public bool _isWallRight;
    public bool _isWallLeft;
    void Update()
    {
        gameObject.transform.position = _player.transform.position;
    }
}
