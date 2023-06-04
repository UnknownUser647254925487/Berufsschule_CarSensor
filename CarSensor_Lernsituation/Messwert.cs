/*
 * @author アンドレアス
 * in group with Josia Happel & Jonas Hesse
 */
using System;
using System.Diagnostics;
using System.Linq;
using static Messwert;


public class Messwert
{
    public enum Sensor {
		sensorL, sensorM, sensorR
	}

    private double speed, distance1, distance2, distance3;
    private Sensor sensor1, sensor2, sensor3;
    private string time;

    #region Constructors
    public Messwert() { }

    public Messwert(string time, double speed, Sensor sensor1, double distance) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
            this.distance1 = distance;
    }
    public Messwert(string time, double speed, Sensor sensor1, double distance1, Sensor sensor2, double distance2) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        this.sensor2 = (Sensor)sensor2;

            this.distance1 = distance1;
            this.distance2 = distance2;

    }
    public Messwert(string time, double speed, Sensor sensor1, double distance1, Sensor sensor2, double distance2, Sensor sensor3, double distance3) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        this.sensor2 = (Sensor)sensor2;
        this.sensor3 = (Sensor)sensor3;
        this.distance1 = distance1;
        this.distance2 = distance2;
        this.distance3 = distance3;
    }
    #endregion

    #region Getters & Setters
    public double Speed {
        get { return this.speed; }
    }
    public double DistanceL {
        get { return this.distance1; }
    }
    public double DistanceM {
        get { return this.distance2; }
    }
    public double DistanceR {
        get { return this.distance3; }
    }

    public Sensor Sensor1{
        get { return this.sensor1; }
    }
    public Sensor Sensor2 {
        get { return this.sensor2; }
    }
    public Sensor Sensor3 {
        get { return this.sensor3; }
    }

    public String Time {
        get { return this.time; }
    }
    #endregion

    #region toString
    public String toString() {
        string s = "";
        if (this.distance1 != 0) {
            s += $"{this.time};{this.speed};{SensorToString(this.sensor1)};{this.distance1}";
        }
        if (this.distance2 != 0) {
            s += $";{SensorToString(this.sensor2)};{this.distance2}";
        }
        if (this.distance3 != 0) {
            s += $";{SensorToString(this.sensor3)};{this.distance3}";
        }
        return s;
    }

    public String SensorToString(Sensor sensor) {
        switch (sensor) {
            case Sensor.sensorL:
                return "SL";
                
             case Sensor.sensorM:
                return "SM";
                
            case Sensor.sensorR:
                return "SR";
                
        default: throw new Exception("Couldn't convert sensor to String");
        }
    }
    #endregion

}
public class MiniMesswert {
    public double Speed { get; set; }
    public double Distance { get; set; }
    public double EnoughDist { get; set; }
    public Sensor Sensor { get; set; }
    public string Time { get; set; }

    #region Constructors
    public MiniMesswert() { }

    
    public MiniMesswert(Messwert messwert) {
        //choose minimal Distance and Sensor
        //get minimal distacne
        double[] arr = {messwert.DistanceL, messwert.DistanceM, messwert.DistanceR };
        this.Distance = arr.Where(x => x != 0).Min();
        Debug.WriteLine($"Mini Dist: {this.Distance}");
        //get the associated sensor
        if(this.Distance == messwert.DistanceL) {
            this.Sensor = messwert.Sensor1;
        }else if (this.Distance == messwert.DistanceM) {
            this.Sensor = messwert.Sensor2;
        }else if (this.Distance == messwert.DistanceR) {
            this.Sensor = messwert.Sensor3;
        } else { throw new Exception("Fooooking Stooooopid"); }


        this.Time = messwert.Time;
        this.Speed = messwert.Speed;
        this.EnoughDist = (this.Distance - (Speed/2));
    }
    #endregion

    
    public string toString() {
        return $"t:{this.Time}; v:{this.Speed}; S:{this.Sensor}; d:{this.Distance}; t/f: {this.EnoughDist}";

    }
}