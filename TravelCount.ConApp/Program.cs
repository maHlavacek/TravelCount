using System;
using System.Threading.Tasks;

namespace TravelCount.ConApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello TravelCount!");

            using var ctrlTravel = Logic.Factory.CreateTravelController();

            var travel = await ctrlTravel.CreateAsync();

            travel.Designation = "Manchester 2020";
            travel.Category = "Reisen";
            travel.Currency = "EUR";
            travel.Friends = "Gerhard;Robert";
            travel = await ctrlTravel.InsertAsync(travel);
            await ctrlTravel.SaveChangesAsync();

            using var ctrlExpense = Logic.Factory.CreateExpenseController();

            var expense = await ctrlExpense.CreateAsync();
            expense.TravelId = travel.Id;
            expense.Amount = 1000;
            expense.Description = "AbschlussRunde";
            expense.Friend = travel.Friends;
            await ctrlExpense.SaveChangesAsync();
        }
    }
}