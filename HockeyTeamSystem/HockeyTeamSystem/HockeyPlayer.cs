using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeamSystem
{
    public class HockeyPlayer : Person 
    {
        //backing fileds, used for store values
        private int _primaryNumber;

        //auto implement, only could be changed by constructor. Can not be changed out side the class
        public PlayerPosition Position { get; private set; }

        //Fully implement property
        public int PrimaryNumber 
        { 
            get { return _primaryNumber; }
            private set 
            {  //Validate PrimaryNumber is between 1 and 99
                if(value<1 || value > 99)
                {
                    throw new ArgumentException("HockeyPlayer primary number must be between 1 and 99");
                }
                _primaryNumber = value; 
            }
        }

        //Define a fully-implemented property for FullName
        //with readonly information
        //Validate FullName is not null, not empty, and not a whitespace
        //Validate FullName contains at minimun 3 characters
        /*
        public string FullName
        {
            get { return _fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Must provide a name");
                }
                if (value.Trim().Length < 3)//Trim white space
                {
                    throw new ArgumentException("Must longer than 3 character");
                }
                _fullName = value.Trim();
            }
        }
        */
        //Define an greedy constructor

        public HockeyPlayer(string fullName, int primaryNumber, PlayerPosition position) : base(fullName)
        {
            PrimaryNumber = primaryNumber;
            Position = position;
        }

        //override the ToString() method to return a CSV
        public override string ToString()
        {
            return $"{FullName},{PrimaryNumber},{Position}";
        }
    }
}
