using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Inheritance
{
    public class HumanDoesNotExistException : ApplicationException
    {
        private readonly string _message;

        public HumanDoesNotExistException()
        {
            
        }

        public HumanDoesNotExistException(int humanId)
        {
            _message = $"Human by Id {humanId} does not exist!\nPlease crete new Human.";
        }

        public override string Message => !string.IsNullOrWhiteSpace(_message) ? _message : base.Message;
    }
}
