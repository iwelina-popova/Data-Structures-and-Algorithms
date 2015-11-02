namespace LinkedListStucture
{
    public class LinkedListTester
    {
        public static void Main()
        {
            /*
            Implement the data structure linked list.
            Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
            Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
            */

            var linkedList = new LinkedList<int>();
            var thirdNumber = new ListItem<int>
            {
                Value = 70,
                NextItem = null
            };
            var secondNumber = new ListItem<int>
            {
                Value = 50,
                NextItem = thirdNumber
            };
            var firstNumber = new ListItem<int>
            {
                Value = 10,
                NextItem = secondNumber
            };

            linkedList.FirstElement = firstNumber;
        }
    }
}
