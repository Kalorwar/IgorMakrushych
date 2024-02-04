using UnityEngine;

public class Enemy : MonoBehaviour
{
  [field: SerializeField] public float Health { get; private set; }

  private MeshRenderer _renderer;

  private void Awake()
  {
    _renderer = GetComponent<MeshRenderer>();
  }

  public Enemy SetColor(Color color)
  {
    _renderer.material.color = color;
    return this;
  }

  public Enemy SetHealth(float heath)
  {
    Health = heath;
    return this;
  }
}