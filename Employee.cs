using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    
    // I, Sahil Hirpara, 000123456 certify that this material is my original work.No other person's work has been used without due acknowledgement.
   
    /// <summary>
    /// Employee modal class containg all method, constructor, attributes and many more
    /// In this class information regarding employyes is stored, alltered and displayed
    /// </summary>
    internal class Employee
    {
        /// <summary>
        /// Attributes: name: is for employee name, number: is for employee number, rate: is for employee rate, hours: is for employees hours, gross is for employees gross income
        /// </summary>
        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross;

        /// <summary>
        /// Constructor for allocating memory to variables
        /// </summary>
        /// <param name="name">employee name</param>
        /// <param name="number">employee number</param>
        /// <param name="rate">employee rate</param>
        /// <param name="hours">employees hours</param>
        public Employee(string name, int number, decimal rate, double hours) {
            this.name = name;   
            this.number = number;   
            this.rate = rate;   
            this.hours = hours; 
        }   

        /// <summary>
        /// calculates Gross income of employee
        /// </summary>
        /// <returns>gross</returns>
        public decimal GetGross()
        {
            if (hours > 40)
            {
                gross = rate * 40 + (rate * (decimal)1.5 * (decimal)(hours - 40));
                return gross;   
            }
            else
            {
                gross = rate * (decimal)hours;
                return gross;
            }
        }

        /// <summary>
        /// returns hours
        /// </summary>
        /// <returns>hours</returns>
        public double GetHours()
        {
            return hours;
        }

        /// <summary>
        /// returns employee name
        /// </summary>
        /// <returns>name</returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// returns employee number
        /// </summary>
        /// <returns>number</returns>
        public int GetNumber()
        {
            return number;
        }

        /// <summary>
        /// returns employee rate
        /// </summary>
        /// <returns>rate</returns>
        public decimal GetRate(){ 
            return rate;
        }

        /// <summary>
        /// returns all data regarding employee in string format
        /// </summary>
        /// <returns>name,number,rate,hour,gross</returns>
        public string toString()
        {
            //return name + number + rate + hours ;
            return $"{name,-20} {number} {rate,6} {hours,6} {gross,6} ";
        }

        /// <summary>
        /// sets employee hours
        /// </summary>
        /// <returns>hours</returns>
        public double SetHours() { 
        return hours;
        }

        /// <summary>
        /// sets employee name
        /// </summary>
        /// <returns>name</returns>
        public string SetName() { 
            return name; 
        }

        /// <summary>
        /// sets employee number
        /// </summary>
        /// <returns>number</returns>
        public int SetNumber()
        {
            return number;
        }

        /// <summary>
        /// sets employee rate
        /// </summary>
        /// <returns>rate</returns>
        public decimal SetRate()
        { 
            return rate;
        }

    }
}
