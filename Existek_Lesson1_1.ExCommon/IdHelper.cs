namespace Existek_Lesson1_1.ExCommon
{
    public class IdHelper
    {
        private static int _idCounter;

        public static int GetNextId()
        {
            return ++_idCounter;
        }
    }
}
