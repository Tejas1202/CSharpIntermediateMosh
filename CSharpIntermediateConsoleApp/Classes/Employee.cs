using System;

namespace CSharpIntermediateConsoleApp.Classes
{
    //For demonstrating Encapsulation
    class Employee
    {
        public DateTime BirthDate { get; private set; }
        public long PhoneNumber { get; set; } //a private field and getter/setter methods will automatically be created by C# compiler (which you can see through IL DASM)

        public Employee(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        private DateTime _projectDate; //But defining getter/setter methods for each and every field will be tedious, hence we use properties

        private DateTime _joiningDate; //As we don't have any logic here, that's where we should use auto implemented properties(Just for demo)

        //Age should be calculated, not set. Hence in this case, auto implemented properties can't come into picture
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        #region Getters and Setter methods used earlier
        public void SetProjectDate(DateTime projectDate)
        {
            _projectDate = projectDate;
        }

        public DateTime GetProjectDate()
        {
            return _projectDate;
        }
        #endregion

        //Property : Short way for writing the above methods used in ProjectDate. Datatype same as that of private field
        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }

    }
}
