using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public string enemyName;

    private void Update()
    {
        MoveAround();

        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }

    private void MoveAround()
    {
        Debug.Log(enemyName + " move at speed " + moveSpeed);
    }

    protected virtual void Attack() {
        Debug.Log(enemyName + " attacks!");
    }

    public void TakeDamage()
    {

    }
}
