﻿/*
 * @author アンドレアス
 * in group with Josia Happel & Jonas Hesse
 */
using System;
using static Messwert;


public class Messwert
{
	public enum Sensor {
		sensorL, sensorM, sensorR
	}


    readonly private double speed, distance1, distance2, distance3;
    readonly private Sensor sensor1, sensor2, sensor3;
    readonly private string time;

    
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
    //Getter for all Variables
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
}
public class MiniMesswert : Messwert{
    private bool enoughDist;
    private double speed, distance;
    private Sensor sensor;
    private string time;

    public MiniMesswert() { }

    public MiniMesswert(Messwert messwert) {
        //choose minimal Distance and Sensor
        if ((messwert.DistanceL <= messwert.DistanceM) && (messwert.DistanceL <= messwert.DistanceR)) {
             this.distance = messwert.DistanceL;
            this.sensor = messwert.Sensor1;
        } else if ((messwert.DistanceM <= messwert.DistanceL) && (messwert.DistanceM <= messwert.DistanceR)) {
            this.distance = messwert.DistanceM;
            this.sensor = messwert.Sensor2;
        } else {
            this.distance = messwert.DistanceR;
            this.sensor = messwert.Sensor3;
        }
        
        time = messwert.Time;
        speed = messwert.Speed;
        enoughDist = (speed/2)>=distance;
    }

    //getter
    public string Time { get;}
    public double Speed { get;}
    public double Sensor { get;}
    public double Distance { get;}
    public bool EnoughDist { get;}
}

