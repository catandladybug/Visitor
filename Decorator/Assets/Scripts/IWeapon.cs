using UnityEngine;

namespace Chapter.Decorator 
{ 
    public interface IWeapon 
    { 
        float Range 
        { 
            get; 
        } 
        float Strength 
        { 
            get; 
        } 
        float Cooldown 
        { 
            get; 
        } 
        float Rate
        {
            get;
        }
    } 
}
