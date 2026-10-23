using UnityEngine;

public class Move : MonoBehaviour
{
    public int Speed = 4;
    void Update()
    {

        transform.position += new Vector3(0, 0, Speed) * Time.deltaTime;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
