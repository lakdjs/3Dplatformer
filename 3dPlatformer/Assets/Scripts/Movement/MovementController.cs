using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Rigidbody _rigidbody;
    
    [SerializeField] private float _speed;
    [SerializeField] private float _rotSpeed;
    [SerializeField] private float _jumpPower;
    [SerializeField] private AnimatorManage _playerAnimationsPlayer;
    [SerializeField] private AudioSource _walkSource;
    [SerializeField] private AudioSource _jumpSource;
    [SerializeField] private AudioSource _jumpSourceDown;
    [SerializeField] private AudioClip _walkClip;
    [SerializeField] private AudioClip _jumpClip;
    [SerializeField] private AudioClip _jumpClipDown;
    [SerializeField] private GameObject _energy;

    private bool _onGround = false;
    void Update()
    {
      
       
        if (Input.GetKeyDown(KeyCode.Space) && _onGround)
        {
            _rigidbody.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
            _playerAnimationsPlayer.PlayJump();
            _jumpSource.PlayOneShot(_jumpClip);
        }
        //OldInput();
        PlayerMove();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _onGround = true;
            _jumpSourceDown.PlayOneShot(_jumpClipDown);
        }

       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Energy")
        {
            Debug.Log("est");
            _speed += 5;
            _jumpPower += 5;
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _onGround = false;
        }
    }
    private void PlayerMove()
    {
        float x = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector3(z * _speed, _rigidbody.velocity.y, x*_speed);
        // if (z != 0 || x != 0)
        // {
        //   _playerAnimationsPlayer.PlayMove();
        // }
        if(x!=0|| z != 0)
        {
            _playerAnimationsPlayer.PlayMove();
        }
        
        else
        {
           _playerAnimationsPlayer.PlayIDLE();
       }
        //if(Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.D)

        //if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.A))
        if (_walkSource.isPlaying == true)
        {

            if (x != 0 || z != 0)
            {
                
            }
            else
            {
                _walkSource.Stop();
            }
        }
        else if(_walkSource.isPlaying == false)
        {
            if(x!=0 || z !=0)
            {
                _walkSource.Play();
            }
            else
            {
                _walkSource.Stop();
            }
            
        }
       
    }

    private void OldInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity = Vector3.forward * _speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.velocity = Vector3.back * _speed;
        }

        if (Input.GetKey(KeyCode.D))     
        {
            _rigidbody.velocity = Vector3.right * _speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.velocity = Vector3.left * _speed;
        }
    }
}
