public class Asteroid : Enemy
{
    public override void Move()
    {
        base.Move();
        transform.Rotate(0,0,0.2f);
    }
}