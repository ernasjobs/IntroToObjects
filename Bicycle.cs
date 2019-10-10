using System;
public class Bicycle{
    private static double currentSpeed;
    private static int currentGear;
    private static bool pushedBell;
    private static double steeringAngle;

    public void Accelerate(){
        currentSpeed+=10;
    }
    public void Decelerate(){
        currentSpeed-=10;
    }
    public void ChangeGear(){
        currentGear=0;
    }
    public void PushBell(){
        pushedBell=false;
    }
    public void SetSteeringAngle(){
        steeringAngle=25.5;
    }

    public void GetStates(){
        Console.WriteLine("Current Speed is: "+currentSpeed);
        Console.WriteLine("Current Gear is: "+currentGear);
        Console.WriteLine("Has bell been pushed?"+pushedBell);
        Console.WriteLine("Current steering angle is: "+steeringAngle);
        Console.ReadKey(true);
    }

}