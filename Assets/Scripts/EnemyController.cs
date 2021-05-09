using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    private Transform _player;
    private Transform _enemy;
    private RaycastHit _hit;

    public EnemyController(Transform player, Transform enemy)
    {
        _player = player;
        _enemy = enemy;
    }

    public void Update()
    {
        var startPosition = _enemy.position;
        var direction = _player.position - _enemy.position;

        var rayCast = Physics.Raycast(startPosition, direction, out _hit, Mathf.Infinity);

        var color = Color.red;

        if (rayCast)
        {
            if (_hit.collider.gameObject.CompareTag("Player") && direction.magnitude < 5.0f)
            {
                color = Color.green;
            }
        }
        Debug.Log(_hit.collider);
        Debug.DrawRay(startPosition, direction, color);
    }
}
