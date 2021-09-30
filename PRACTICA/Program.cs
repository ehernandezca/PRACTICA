using System;
using System.Linq;
using System.Text;

namespace PRACTICA
{
    class Vehiculo
    {
        private string color, motor;
        public Vehiculo(string color, string motor)
        {
            setColor(color);
             setMotor(motor);
        }
        //*Metodos Modificadores*/
        public void setColor(string n)
            
        {
            color = n;
        }

        public void setMotor(string e)

            {
                motor = e;
        }
        /*ACCESORES*/
        public string getColor()
        {
            return color;
        }
        public string getMotor()
        {
            return motor;
         }
        public void mostrarVehiculo()
        {
            Console.Write("/nColor:" + getColor() + "/nMotor:" + getMotor());

        }
        }
    public class Principal
    {
        public static void Main()
        {
            string color, motor;
            Console.Write("Ingresa el color");
            color = Console.ReadLine();
            Console.WriteLine("Ingresar motor");
            motor = Console.ReadLine();
        }
    }
