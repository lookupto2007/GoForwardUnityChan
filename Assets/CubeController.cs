using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -12.0f;

    //消滅位置
    private float deadline = -10.0f;

    //（課題）PlayOneShot用の音源登録用
    public AudioClip sound1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
//        GetComponent<AudioSource>().volume = 0.0f;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag != "UnityChanTag")
        {
            GetComponent<AudioSource>().PlayOneShot(sound1);
        }
    }

}
