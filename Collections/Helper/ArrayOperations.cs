namespace Collections.Helper
{
    public class ArrayOperations
    {
        public void ArrayImpress(int[] collection){foreach (int item in collection){System.Console.WriteLine(item);}}
        public void BlubleSortOrder(ref int[] collection){
            int temp;
            for (int i = 0; i < collection.Length; i++)
            {
                for (int j = 0; j < collection.Length - 1; j++)
                {
                    if(collection[j] >= collection[j+1]){
                        temp = collection[j+1];
                        collection[j+1]=collection[j];
                        collection[j]=temp;
                    }
                }
            }
        }
    }
}