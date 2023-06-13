using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControuller : MonoBehaviour
{
    Vector3 dir = Vector3.zero;//ˆÚ“®•ûŒü‚ğ•Û‘¶‚·‚é•Ï”

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;

        //ˆÚ“®•ûŒü‚ğƒZƒbƒg
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized *speed* Time.deltaTime;

        //‰æ–Ê“àˆÚ“®§ŒÀ
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        if(dir.y==0)
        {
            anim.Play("Player");
        }
        else if(dir.y==1)
        {
            anim.Play("PlayerL");
        }
        else if(dir.y==-1)
        {
            anim.Play("PlayerR");
        }
           
        
    }
}
