using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBlock : MonoBehaviour
{
    public float moreJump;

    private Rigidbody _rigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _rigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if(_rigidbody != null )
            {
                _rigidbody.AddForce(Vector3.up * moreJump, ForceMode.Impulse);
            }
        }
    }
}
