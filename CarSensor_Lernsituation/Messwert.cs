/*
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


    private double speed, distance1, distance2, distance3;
    private Sensor sensor1, sensor2, sensor3;
    private string time;

    
    public Messwert(string time, double speed, Sensor sensor1, double distance) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        if (distance > 0) {
            this.distance1 = distance;
        }
    }
    public Messwert(string time, double speed, Sensor sensor1, double distance1, Sensor sensor2, double distance2) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        this.sensor2 = (Sensor)sensor2;

        if (distance1 > 0) {
            this.distance1 = distance1;
        }
        if (distance2 > 0) {
            this.distance2 = distance2;
        }

    }
    public Messwert(string time, double speed, Sensor sensor1, double distance1, Sensor sensor2, double distance2, Sensor sensor3, double distance3) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        this.sensor2 = (Sensor)sensor2;
        this.sensor3 = (Sensor)sensor3;
        if (distance1 > 0) {
            this.distance1 = distance1;
        }
        if (distance2 > 0) {
            this.distance2 = distance2;
        }
        if (distance3 > 0) {
            this.distance3 = distance3;
        }
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
            s += $"{this.time};{this.speed};{this.sensor1};{this.distance1};";
        }
        if (this.distance2 != 0) {
            s += $"{this.sensor2};{this.distance2};";
        }
        if (this.distance3 != 0) {
            s += $"{this.sensor3};{this.distance3};";
        }
        return s;
    }
}