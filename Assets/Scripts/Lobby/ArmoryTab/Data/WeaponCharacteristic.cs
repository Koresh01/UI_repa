using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon Characteristic", order = 51)]
public class WeaponCharacteristic : ScriptableObject
{
   [SerializeField] private string _name;
   public string Name => _name;
   [SerializeField] private WeaponTypes _type;
   public WeaponTypes Type => _type;
   [SerializeField] private int _damage;
   public int Damage => _damage;
   [SerializeField] private int _fireRate;
   public int FireRate => _fireRate;
   [SerializeField] private int _cooldown;
   public int Cooldown => _cooldown;
   [SerializeField] private int _distance;
   public int Distance => _distance;
   [SerializeField] private int _spread;
   public int Spread => _spread;
   [SerializeField] private int _bulletCount;
   public int BulletCount => _bulletCount;
   [SerializeField] private int _explosionArea;
   public int ExplosionArea => _explosionArea;
}
