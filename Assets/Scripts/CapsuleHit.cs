using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleHit : MonoBehaviour
{
    [SerializeField]
    private CapsuleInfo capsuleInfo;

    private float colorChangedElapsedTime;
    

    // Start is called before the first frame update
    void Start()
    {
        capsuleInfo = gameObject.GetComponent<CapsuleInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (colorChangedElapsedTime > 0f)
        {
            //カウントダウンする
            colorChangedElapsedTime -= Time.deltaTime;
        }
        else
        {
            // 青色に変更する
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "bullet")
        {
            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);

            // 赤色に変更する
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            colorChangedElapsedTime = 1.0f;

            capsuleInfo.Damage(20);
}
    }
}
