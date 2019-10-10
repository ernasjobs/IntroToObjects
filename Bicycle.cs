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
    public void ChangeGearUp(){
        currentGear+=1;
    }
    public void ChangeGearDown(){
        currentGear-=1;
    }
    public void PushBell(){
        pushedBell=true;
    }
    public void TurnLeft(){
        steeringAngle+=5;
    }
    public void TurnRight(){
        steeringAngle-=5;
    }

    public void GetStates(){
        Console.WriteLine("Current Speed is: "+currentSpeed);
        Console.WriteLine("Current Gear is: "+currentGear);
        Console.WriteLine("Has bell been pushed?"+pushedBell);
        Console.WriteLine("Current steering angle is: "+steeringAngle);
        Console.ReadKey(true);
    }

}