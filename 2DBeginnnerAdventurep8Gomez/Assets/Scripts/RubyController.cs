using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyContro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertital = Input.GetAxis("vertital");


        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertital;

        transform.position = position;
    }
}
