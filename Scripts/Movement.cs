using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float current_pos = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(current_pos, 0f, 0f);
        //Move character
        transform.position += movement * Time.deltaTime * moveSpeed;
        //Flip character
        Vector3 characterScale = transform.localScale;
        print(characterScale);
        if (current_pos < 0)
        {
            characterScale.x = Mathf.Abs(characterScale.x) * -1;
        }
        if (current_pos > 0)
            characterScale.x = Mathf.Abs(characterScale.x);
        transform.localScale = characterScale;
        animator.SetFloat("moveSpeed", Mathf.Abs(current_pos * moveSpeed));
    }
}
