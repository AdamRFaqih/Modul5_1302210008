class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for(int i = 0;i < storedData.Count; i++)
        {
            dynamic data1, data2;
            data1= storedData[i];
            data2= inputDates[i];
            Console.WriteLine(data1+ data2);
        }
    }
}

class Utama
{
    public static void Main(string[] args)
    {
        SimpleDataBase<string> simpleDataBase= new SimpleDataBase<string>();

        simpleDataBase.addNewData("13, yang disimpan pada waktu UTC ");
        simpleDataBase.addNewData("02, yang disimpan pada waktu UTC ");
        simpleDataBase.addNewData("21, yang disimpan pada waktu UTC ");
        simpleDataBase.printAllData();
    }

}