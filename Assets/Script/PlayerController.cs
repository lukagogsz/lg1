using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    private float moveSpeed = 5f;
    [SerializeField]
    private float rotateSpeed = 2000f ;
    [SerializeField]
    private float jumpforce = 300f;
    [SerializeField]
    private Rigidbody rb;




    void Update()
    {
        Vector3 dir = new Vector3(
            0, 0, Input.GetAxis("Vertical"));
        dir.Normalize();
        transform.Translate(dir * moveSpeed * Time.deltaTime);


        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpforce, 0);
        }



    }
}
