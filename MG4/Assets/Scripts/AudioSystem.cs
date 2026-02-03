using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{

    [SerializeField] private AudioSource _pointSound;
    [SerializeField] private AudioSource _gameOverSound;
    private void Start()
    {
        GameController.Instance.player.pointEvent += pointEventHandler;
        GameController.Instance.player.gameOverEvent += gameOverEventHandler;
        _pointSound.Stop();
        _gameOverSound.Stop();
    }
    
    public void pointEventHandler()
    {
        _pointSound.Play();
    }

    public void gameOverEventHandler()
    {
        _gameOverSound.Play();
    }
}
