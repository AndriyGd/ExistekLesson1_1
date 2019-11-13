using System;

namespace Existek_Lesson1_1.Inheritance.Common
{
    using ExCommon;

    public class Human
    {
        #region Class Fields

        private int _age;
        #endregion

        #region Class Properties

        public int Id { get; }
        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Age must be more than 0");

                _age = value;
            }
        } 
        #endregion

        public Human()
        {
            Id = IdHelper.GetNextId();
        }
    }
}
