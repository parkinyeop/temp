using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public enum Type { Orc, Skelleton, Mage, Shell, Boss}
    public Type enemyType;              //Attack 메서드에서 공격 타입을 설정하기 위해
    public int curHealth;
    public int maxHealth;
    public Transform target;            //플레이어 타겟

    public GameObject projectile;       //원거리용 발사체
    public BoxCollider meleeAttack;     //밀리 어택용 컬리젼 박스
    public NavMeshAgent nav;            //네비 매쉬를 사용
    public Rigidbody rigid;
    public BoxCollider boxCollider;     //피격에 사용되는 기본 컬리젼
    public Animator anim;

    public bool isChase;                //타겟을 향해 이동중
    public bool isAttack;
    public bool isDead;

    
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();    
        nav = GetComponent<NavMeshAgent>();
        boxCollider = GetComponent<BoxCollider>();
    }

    private void Start()
    {
        meleeAttack.enabled = false;        //밀리 어택 컬리젼을 꺼 둠
        //StartCoroutine(Attack());           //코루틴 테스트용 임시 코드
    }
    void Thinking()
    {

    }

    //IEnumerator Attack()
    //{
    //    meleeAttack.enabled = true;         //밀리어택의 컬리젼을 켜 줌
    //    anim.SetBool("isAttack", true);
    //}
}
