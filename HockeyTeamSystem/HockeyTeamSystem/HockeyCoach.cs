using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////Those are called name space////////////////////////////
///
/*
 * 
    Terminologies to study for: namespace, class name, constructor, fields, auto-implemented property,
    fully-implemented property, local variable, method parameters, method argument, method return type
 * 
 */

namespace HockeyTeamSystem
{
    //Define a class named HockeyCoach that inherits from the base class Person
    public class HockeyCoach : Person //////////HockeyCoach : Person////////// this is called class name////////////////////
    {
        //Define a readonly public field that can be assigned a value
        //in the constructor
        //[JsonInclude]
        public readonly string StartDate;  //////////////////////this is called filed ///////////////////////////////

        //Define a greedy constructor that takes a startDate as a parameter
        //The ": base(fullName) means pass fullName to the base class(person) constructor
        public HockeyCoach(string fullName, string startDate): base (fullName)  //////// this works as a constructor//////////
          //    (string fullName, string startDate): base (fullName)
          //////////////These are parameters /////////////
          //    string (在参数名字前面的)
          ///////////this is called data type
          //    full name/ start date
          ////////////this is called parameter name///////////////
          ///            // this called data type
        {
            this.StartDate = startDate;
            
        }
        //Override the ToString() method to return a CSV
        public override string ToString()
            // string
            // this called method return type
        {
            return $"{FullName},{StartDate}";
        }
    }

    
}
