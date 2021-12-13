using System;

public interface IMoveable
{
    public float MovementSpeed { get; set; }

    public void Move();
}