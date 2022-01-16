namespace Collections.Helper
{
    public class ArrayOperations
    {
        public void PrintArray(int[] collection){
            var line = string.Join(", ", collection);
            System.Console.WriteLine(line);
        }
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
        public void VerificExist(int[] a, int n1){
            if(Array.Exists(a,element => element == n1))System.Console.WriteLine($"O valor {n1} existe no array");
            else System.Console.WriteLine("O array não possue o valor mencionado");
        }
    }
}