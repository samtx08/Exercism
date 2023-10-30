using System;

class RemoteControlCar
{
    private int _drivenMeters;
    private int _batteryPercentage = 100;
    
    
    public static RemoteControlCar Buy()=> new RemoteControlCar();

    public string DistanceDisplay()=> $"Driven {_drivenMeters} meters";

    public string BatteryDisplay()=> _batteryPercentage > 0 ? $"Battery at {_batteryPercentage}%" : "Battery empty"; 
        
    public void Drive()
    {
        if(this._batteryPercentage > 0){
            
            this._drivenMeters += 20;
            this._batteryPercentage --;
            
        }

    }
}
