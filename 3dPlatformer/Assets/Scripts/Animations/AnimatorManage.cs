using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManage : MonoBehaviour
{
    private const string Jump = "Jump";
    private const string Move = "Move";
    [SerializeField] private Animator _animator;
    public void PlayIDLE()
    {
        _animator.SetBool(Move, false);
    }
    public void PlayJump()
    {
        _animator.SetTrigger(Jump);
    }
    public void PlayMove()
    {
        _animator.SetBool(Move, true);
    }
}
