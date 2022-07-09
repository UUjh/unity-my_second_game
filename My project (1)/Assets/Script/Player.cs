using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    float mouseX = 0;

    CharacterController charCtrl;
    Animator anim;

    void Start()
    {
        charCtrl = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        mouseX += Input.GetAxis("Mouse X") * moveSpeed;
        transform.eulerAngles = new Vector3(0, mouseX, 0);

        anim.SetFloat("Speed", charCtrl.velocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch(other.tag)
        {
            case "Enemy":
                SceneManager.LoadScene("Lose");
                break;
            case "Exit":
                SceneManager.LoadScene("Win");
                break;
        }
    }

    void PlayerMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);

        charCtrl.Move(transform.TransformDirection(move) * Time.deltaTime * moveSpeed);
    }



}
