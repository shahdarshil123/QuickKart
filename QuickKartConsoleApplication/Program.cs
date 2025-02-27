namespace QuickKartConsoleApplication
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int customerId = 0;
        //    QuickKart customer1 = new QuickKart("Darshil","Shah",8576546153, customerId++);
        //    //Console.WriteLine(customer1
        //    Console.WriteLine(customer1.displayDetails());
        //    //customer1.FirstName = "Test";
        //    customer1.PhoneNumber = 8576546154;
        //    Console.WriteLine(customer1.displayDetails());
        //}
        static void Main(string[] args)
        {
            EliteCustomer eliteCustomer = new EliteCustomer("Darshil Shah","darshilshah622@gmail.com",8576546153,"2767 Washington Stret");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("CustomerID = {0}\nCustomerName = {1}\nEmailId = {2}\n" +
                "ContactNumber = {3}\nContactAddress = {4}",
                eliteCustomer.CustomerId, eliteCustomer.CustomerName, eliteCustomer.EmailId,
                eliteCustomer.ContactNumber, eliteCustomer.ContactAddress);
        }
    }
}
