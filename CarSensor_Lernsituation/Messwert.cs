using System;
using static Messwert;


public class Messwert
{
	public enum Sensor {
		sensorL, sensorM, sensorR
	}


    private double speed, distanceL, distanceM, distanceR;
    private Sensor sensor1, sensor2, sensor3;
    private string time;

    public Messwert(string time, double speed, Sensor sensor1, double distance) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        if (distance > 0) {
            switch (sensor1) {
                case Sensor.sensorL:
                    this.distanceL = distance;
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance;
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance;
                    break;
            }
        }
    }
    public Messwert(string time, double speed, Sensor sensor1, double distance1, Sensor sensor2, double distance2) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        this.sensor2 = (Sensor)sensor2;

        if (distance1 > 0) {
            switch (sensor1) {
                case Sensor.sensorL:
                    this.distanceL = distance1;
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance1;
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance1;
                    break;
            }
        }
        if (distance2 > 0) {
            switch (sensor2) {
                case Sensor.sensorL:
                    this.distanceL = distance2;
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance2;
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance2;
                    break;
            }
        }

    }
    public Messwert(string time, double speed, Sensor sensor1, double distance1, Sensor sensor2, double distance2, Sensor sensor3, double distance3) {
        this.time = time;
        this.speed = speed;
        this.sensor1 = (Sensor)sensor1;
        this.sensor2 = (Sensor)sensor2;
        this.sensor3 = (Sensor)sensor3;
        if (distance1 > 0) {
            switch (sensor1) {
                case Sensor.sensorL:
                    this.distanceL = distance1;
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance1;
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance1;
                    break;
            }
        }
        if (distance2 > 0) {
            switch (sensor2) {
                case Sensor.sensorL:
                    this.distanceL = distance2;
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance2;
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance2;
                    break;
            }
        }
        if (distance3 > 0) {
            switch (sensor3) {
                case Sensor.sensorL:
                    this.distanceL = distance3;
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance3;
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance3;
                    break;
            }
        }
    }

    public String toString() {
        string s = "";
        if (this.distanceL != 0) {
            s += $"{this.sensor1}; {this.time}; {this.speed}; {this.distanceL}\n";
        }
        if (this.distanceM != 0) {
            s += $"{this.sensor2}; {this.time}; {this.speed}; {this.distanceM}\n";
        }
        if (this.distanceR != 0) {
            s += $"{this.sensor3}; {this.time}; {this.speed}; {this.distanceR}\n";
        }
        return s;
    }
}