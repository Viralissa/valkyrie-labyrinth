using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private EnemyView _enemyView;

    private EnemyController _enemyController;

    private void Awake()
    {
        _enemyController = new EnemyController(_enemyView.Player, _enemyView.Enemy);    
    }

    private void Update()
    {
        _enemyController.Update();
    }
}
