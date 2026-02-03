using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void pointDelegate();
    public event pointDelegate pointEvent;

    public delegate void gameOverDelegate();
    public event gameOverDelegate gameOverEvent;


    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private AudioSource _jumpSound;

    private int _points;

    private void Start()
    {
        _points = 0;
        _jumpSound.Stop();
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jump);
            _jumpSound.Play();

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "PointsWall":
                _points++;
                pointEvent.Invoke();
                Destroy(collision.gameObject);
                break;


            case "Pipe":
                gameOverEvent.Invoke();
                gameObject.SetActive(false);
                break;
        }
    }

    
    public int getPoints()
    {
        return _points;
    }
}
