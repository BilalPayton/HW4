using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject _topPipe;
    [SerializeField] private GameObject _bottomPipe;
    [SerializeField] private GameObject _pointsWall;
    private float _pipeTimer;

    public static GameController Instance { get; private set; }
    public Player player { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
        GameObject playerObj = GameObject.FindWithTag("Player");
        player = playerObj.GetComponent<Player>();
    }
    
    private void Start()
    {
        Instantiate(_topPipe);
        Instantiate(_bottomPipe);
        Instantiate(_pointsWall);
        _pipeTimer = 4.0f;

    }
    private void Update()
    {
        _pipeTimer -= Time.deltaTime;

        if (_pipeTimer <= 0)
        {
            Instantiate(_topPipe);
            Instantiate(_bottomPipe);
            Instantiate(_pointsWall);
            _pipeTimer = 4.0f;
        }
    }
}
