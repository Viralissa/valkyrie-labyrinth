using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController
{
    private Transform _player;
    private Transform _enemy;
    private RaycastHit _hit;
    private float _speed = 5.0f;

    public EnemyController(Transform player, Transform enemy)
    {
        _player = player;
        _enemy = enemy;
    }

    public void Update()
    {
        if (_player != null && _enemy != null) 
        {
            var startPosition = _enemy.position;
            var direction = _player.position - _enemy.position;
            startPosition.y += 0.5f;

            var rayCast = Physics.Raycast(startPosition, direction, out _hit, Mathf.Infinity);

            var color = Color.red;

            if (rayCast)
            {
                if (_hit.collider.gameObject.CompareTag("Player") && direction.magnitude < 5.0f)
                {
                    var rotation = Quaternion.LookRotation(direction);
                    _enemy.transform.rotation = rotation;
                    _enemy.transform.position = Vector3.MoveTowards(_enemy.transform.position,
                        _player.transform.position, _speed * Time.deltaTime);
                    color = Color.green;
                }
            }
            Debug.Log(_hit.collider);
            Debug.DrawRay(startPosition, direction, color);
        }
    }
}
