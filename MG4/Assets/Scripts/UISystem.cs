using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class UISystem : MonoBehaviour
{
    [SerializeField] private TextMeshPro _pointsText;
    [SerializeField] private GameObject _gameOverText;

    private void Start()
    {
        _gameOverText.SetActive(false);
        GameController.Instance.player.pointEvent += pointEventHandler;
        GameController.Instance.player.gameOverEvent += gameOverEventHandler;
    }

    public void pointEventHandler()
    {
        _pointsText.text = "Points: " + GameController.Instance.player.getPoints();
    }

    public void gameOverEventHandler()
    {
        _gameOverText.SetActive(true);
    }

}
