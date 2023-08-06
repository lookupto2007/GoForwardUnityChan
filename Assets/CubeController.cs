using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //�L���[�u�̈ړ����x
    private float speed = -12.0f;

    //���ňʒu
    private float deadline = -10.0f;

    //�i�ۑ�jPlayOneShot�p�̉����o�^�p
    public AudioClip sound1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //��ʊO�ɏo����j������
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
