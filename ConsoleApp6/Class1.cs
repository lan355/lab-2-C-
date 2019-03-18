using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers
{
    class Complex
    {
         double module;
         double argument;

        public Complex(double module, double argument)
        {
            this.module = module;
            this.argument = argument;
        }

        public double Module { get => module; set => module = value; }
        public double Argument { get => argument; set => argument = value; }

        public override string ToString()
        {
            return "Тригонометрическая форма: " + module.ToString() + "*(Cos(" + argument.ToString() + ")+i*Sin(" + argument.ToString() + "))" + "\n" +
                "Алгебраическая форма: " + Math.Round(this.module * Math.Cos(this.argument), 2) + "+" + Math.Round(this.module * Math.Sin(this.argument), 2) + "i";

        }

        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex (x.Module * y.Module, x.Argument + y.Argument);
        }

        public static Complex operator /(Complex x, Complex y)
        {
            return new Complex(Math.Round(x.Module / y.Module,2), x.Argument - y.Argument);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(Math.Round(x.Module * Math.Cos(x.Argument), 2) + Math.Round(y.Module * Math.Cos(y.Argument), 2), Math.Round(x.Module * Math.Sin(x.Argument), 2) + Math.Round(y.Module * Math.Sin(y.Argument), 2));
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(Math.Round(x.Module * Math.Cos(x.Argument), 2) - Math.Round(y.Module * Math.Cos(y.Argument), 2), Math.Round(x.Module * Math.Sin(x.Argument), 2) - Math.Round(y.Module * Math.Sin(y.Argument), 2));
        }


    }
}
