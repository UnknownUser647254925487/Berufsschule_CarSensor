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

    public Messwert(string time, double speed, double distance, Sensor sensor1){
		this.time = time;
		this.speed=speed;
        this.sensor1 = (Sensor) sensor1;
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
    public Messwert(string time, double speed, double distance1, Sensor sensor1, double distance2, Sensor sensor2) {
        this.time = time;
        this.speed = speed;
        this.sensor1 =(Sensor)sensor1;
        this.sensor2 =(Sensor)sensor2;
        for (int i = 0; i < 2; i++) { //twice bcs 2 device inputs
            switch (sensor) {
                case Sensor.sensorL:
                    this.distanceL = distance{i};
                    break;
                case Sensor.sensorM:
                    this.distanceM = distance{i};
                    break;
                case Sensor.sensorR:
                    this.distanceR = distance{i};
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
            for (int i = 0; i < 3; i++) { //thrice bcs 3 device inputs
                switch (sensor) {
                    case sensor.sensorL:
                        this.distanceL = distance{i};
                        break;
                    case sensor.sensorM:
                        this.distanceM = distance{i};
                        break;
                    case sensor.sensorR:
                        this.distanceR = distance{i};
                        break;
                }
            }
    }

    public static void toString() {
        string s;
        s = $"{this.sensor1}; {this.time}; {this.speed}; {this.distance1}";
        return s
    }
    public static void toString() {
        string s;
        s = $"{this.sensor1}; {this.time}; {this.speed}; {this.distance1}";
        s += $"{this.sensor2}; {this.time}; {this.speed}; {this.distance2};";
        return s
    }
    public static void toString() {
        string s;
        s = $"{this.sensor1}; {this.time}; {this.speed}; {this.distance1}";
        s += $"{this.sensor2}; {this.time}; {this.speed}; {this.distance2};";
        s += $"{this.sensor3}; {this.time}; {this.speed}; {this.distance3};";
        return s
    }

    public static void main(string[] args) {
        Messwert test = new Messwert("time", 3, 3, Sensor.sensorL);
        Console.WriteLine(test.toString());
    }
}
