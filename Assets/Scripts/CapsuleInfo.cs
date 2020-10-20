﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleInfo : MonoBehaviour
{
    public int hitPoint = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //HPが0になったときに敵を破壊する
        if (hitPoint <= 0)
        {
            Destroy(gameObject);
        }

    }

    //ダメージを受け取ってHPを減らす関数
    public void Damage(int damage)
    {
        //受け取ったダメージ分HPを減らす
        hitPoint -= damage;
    }
}
