using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static bool isOver = false;
    public float jump = 5f;
    public float maxheight = 4.8f;
    public float minheight = -4.73f;
    public Rigidbody2D rigid;
    public static float nowTime;
    public float waitTime;
    public AudioClip JumpSoundClip;
    public AudioClip StarHit;
    public AudioClip GameOverClip;
    AudioSource audioSource;

    Vector2 pos;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nowTime = 0;
        waitTime = 3;
    }

    void Update()
    {
        nowTime += Time.deltaTime;

        if (nowTime < waitTime) // 게임 시작 직후 2 ~ 3초 (waitTime) 있다가 시작
        {
            rigid.velocity = new Vector2(0, 0);
            rigid.position = new Vector2(-8, 4);
        }

        else
        {
            pos = this.gameObject.transform.position; //현재 player의 위치 값 받아오기

            if (Input.GetKeyDown(KeyCode.Space) && !isOver && pos.y <= maxheight)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(
                    GetComponent<Rigidbody2D>().velocity.x, jump);
                audioSource.PlayOneShot(JumpSoundClip);
            }
        }
    }
    //물리적 충돌 - 화살 hit
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!isOver)
        {
            RankingSave rs = new RankingSave();
            rs.rankingSave();
        }
        isOver = true;
        audioSource.PlayOneShot(GameOverClip);

    }
    //통과(isTrigger) - 그라운드
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "ground" & !isOver)
        {
            RankingSave rs = new RankingSave();
            rs.rankingSave();
            isOver = true;
            audioSource.PlayOneShot(GameOverClip);

        }
        else if(!isOver)
        {
            audioSource.PlayOneShot(StarHit);
        }
    }
}