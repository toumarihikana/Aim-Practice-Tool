using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shotSpeed = 2000;
    public int shotCount = 30;
    private float shotInterval;


    [SerializeField]
    private MenuVisible menuVisible;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuVisible.IsMenuVisible)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {

                shotInterval += 1;

                if (shotInterval % 10 == 0 && shotCount > 0)
                {
                    shotCount -= 1;

                    GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                    Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                    bulletRb.AddForce(transform.forward * shotSpeed);


                    //射撃されてから3秒後に銃弾のオブジェクトを破壊する.
                    Destroy(bullet, 3.0f);
                }

            }

            else if (Input.GetKeyDown(KeyCode.R))
            {
                shotCount = 30;

            }
        }
        

    }
}
