using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;

                case "t":
                    result = AreaOfTriangle(num1, num2);
                    break;

                case "c":
                    result = AreaOfCircle(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            /*if(num1 == 1)
            {
                return (num2 - 4);
            }
            else if(num1 == (num2 - 1))
            {
                return (num2);
            }
            else if(num1 == num2)
            {
                return (num2 + 4);
            }
            else
            {
                return (num1 + num2);
            }*/


            String binary1 = num1.ToString();
            String binary2 = num2.ToString();
            if (Regex.IsMatch(binary1, "^[01]+$") && Regex.IsMatch(binary2, "^[01]+$"))
            {
                String binarysum = binary1 + binary2;
                String result = Convert.ToInt32(binarysum, 2).ToString();
                return Convert.ToDouble(result);
                //convert binary to decimal
            }
            return (num1 + num2);



        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            /*else if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException("Either numbers must not be 0");
            }*/
            /*else if(num2 == 0)
            {
                return double.PositiveInfinity;
            }*/
            else
            {
                return (num1 / num2);
            }

        }

        public double Factorial(double num1)
        {

            double result = 1;
            double i;

            if (num1 < 0 || num1 % 1 != 0)
            {
                throw new ArgumentException("Please enter a positive whole number");
            }
            else
            {
                for (i = 1; i <= num1; i++)
                {
                    result = result * i;
                }

                return result;
            }
        }

        public double AreaOfTriangle(double height, double length)
        {
            if (height < 0 || length < 0)
            {
                throw new ArgumentException("Height or length cannot be negative");
            }
            else if (height == 0 || length == 0)
            {
                throw new ArgumentException("Height or length cannot be zero");
            }

            return Divide(Multiply(height, length), 2);
        }

        public double AreaOfCircle(double radius)
        {
            double pi = 3.14;

            if (radius < 0 || radius == 0)
            {
                throw new ArgumentException("Radius cannot be negative or zero");
            }
            return Multiply(pi, Multiply(radius, radius));
        }



        #region UnknownFunctions Lab 1
        public double UnknownFunctionA(double num1, double num2)
        {

            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        public double UnknownFunctionB(double num1, double num2)
        {

            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));

        }
        #endregion





        public decimal Availability(double num1, double num2)
        {

            return decimal.Round((Decimal)Multiply(Divide(num1, num2), 100), 1);
        }

        public double AvailabilityClass(double num1)
        {
            if (num1 < 99)
            {
                return 1;
            }
            else if (num1 == 99)
            {
                return 2;
            }
            else if (num1 == 99.9f)
            {
                return 3;
            }
            else if (num1 == 99.99f)
            {
                return 4;
            }
            else if (num1 == 99.999f)
            {
                return 5;
            }
            else if (num1 == 99.9999f)
            {
                return 6;
            }
            else if (num1 == 99.99999f)
            {
                return 7;
            }
            else
            {
                return 0;
            }



        }


        public double CurrentFailureIntensity(double initialFailure, double currAvgFailure, double totalFailures)
        {
            return Multiply(initialFailure, Subtract(1, Divide(currAvgFailure, totalFailures)));
        }

        public int AvgExpectedFailures(double time, double initialFailure, double totalFailure)
        {
            return (int)Multiply(totalFailure, Subtract(1, Math.Exp(-Multiply(Divide(initialFailure,totalFailure),time))));
        }

        public decimal CurrentFailureIntensityLogModel(double initialFailure,double decayParam, double avgExptFailure)
        {
            return decimal.Round((decimal)Multiply(initialFailure, Math.Exp(Multiply(-decayParam, avgExptFailure))),2);
        }
        

    }
}
