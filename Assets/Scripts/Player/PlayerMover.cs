using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float scaledMoveSpeed = _speed * Time.deltaTime;
        Vector3 move = Quaternion.Euler(0, transform.localEulerAngles.y, 0) * Vector3.right;
        transform.position += move * scaledMoveSpeed;
    }
}
