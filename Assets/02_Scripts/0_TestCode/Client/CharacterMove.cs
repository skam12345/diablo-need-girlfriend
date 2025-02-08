using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform lookedcam;
    public bool onMove = false;



    public bool isHold = false;

    public float moveSpeed = 2f;
    public float runSpeed = 8f;
    public float totalSpeed;
    public float rotSpeed = 120f;
    private Vector3 moveDir;

    public int heroIndex;



    //점프용
    public float jumpForce = 7f;
    private Rigidbody rb;
    public bool isGrounded = true;


    void Start()
    {
        totalSpeed = moveSpeed;
        heroIndex = 1; //TODO: 나중에 스토리로 설정하기


        //점프용
        rb = GetComponent<Rigidbody>();

    }
    public void HeroChange(int changeHeroNum)
    {
        Transform beforeHero = transform.GetChild(heroIndex);
        beforeHero.gameObject.SetActive(false);
        heroIndex = changeHeroNum;
        transform.GetChild(heroIndex).gameObject.SetActive(true);
        //TODO: 이 때, GetChild가 가진 class에 있는 스텟값 init하기!!
    }



    void Update()
    {

   

        //이동
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");
        Debug.Log(moveDir);
        moveDir = new Vector3(h, 0, v);

        transform.Translate(moveDir*Time.deltaTime*moveSpeed);



	} // 달리기



}
