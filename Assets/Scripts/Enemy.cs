using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character//ここには継承したいものを書く（最初にスクリプトを作った時はMonoBehaviourが入っている）
{
    //衝突したら呼ばれる
    private void OnCollisionEnter(Collision collision)
    {
        Player a = collision.gameObject.GetComponent<Player>();

        if (a != null)
        {
            Destroy(gameObject);
        }
    }
}
