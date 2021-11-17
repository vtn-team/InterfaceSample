using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Enemy : FieldObject
{
    /// <summary>
    /// コライダー無効化時間
    /// </summary>
    [SerializeField]
    float disableCollisionDuration = 0.1f;

    protected virtual void Start()
    {
        StartCoroutine(EnableCollider());
    }

    /// <summary>
    /// コライダーを有効化する
    /// </summary>
    public IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(disableCollisionDuration);
        GetComponent<Collider>().enabled = true;
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player)
        {
            Destroy(gameObject);
            Debug.Log($"{name}はプレイヤーに触れ消えた");
        }
    }
}
