using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private GameObject[] targets; // 目的地
    private int nextIndex = 0; //次の目的地のインデックス
    private UnityEngine.AI.NavMeshAgent agent; //自動で動くオブジェクト

    void Start()
    {
        // アタッチされているオブジェクトのNaveMeshAgentを取得
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        // 目的地情報の取得(順番通りに取得できるわけではない)
        targets = GameObject.FindGameObjectsWithTag("Pillar");

        // 最初の目的地を設定
        agent.destination = targets[nextIndex].transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {

        // 衝突対象が目的地のピラーだったら次の目的地を設定する
        if (collision.gameObject.tag == "Pillar")
        {

            // 次の目的地のインデックスにする
            if (nextIndex < targets.Length - 1)
            {
                nextIndex++;
            }
            else
            {
                nextIndex = 0;
            }

            // インデックスに応じた目的地を設定する
            agent.destination = targets[nextIndex].transform.position;
        }

    }
}
