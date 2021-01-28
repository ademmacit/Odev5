using Odev5.Abstract;
using Odev5.Concrete;
using Odev5.entities;
using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameManager gameManager = new GameManager();
            IStudentManager studentManager = new StudentManager(new DebugStudentValidator());
            ISaleManager standartSaleManager = new SaleManager(new StandartPriceSale());
            ISaleManager discountSaleManager = new SaleManager(new NewYearsSale(25));

            studentManager.AddStudent(new Student()
            { Id = 1, Name = "adem", Surname = "macit", NationalityNumber = "45465465" });
            studentManager.AddStudent(new Student()
            { Id = 2, Name = "emre", Surname = "begit", NationalityNumber = "45465465" });
            studentManager.AddStudent(new Student()
            { Id = 3, Name = "ali", Surname = "veli", NationalityNumber = "45465465" });

            foreach (var student in studentManager.ListStudents())
                Console.WriteLine(student.Name + " " + student.Surname);


            gameManager.AddGame(new Game() { Id = 1, Name = "gta" , Price = 100});
            gameManager.AddGame(new Game() { Id = 2, Name = "dota", Price = 150 });
            gameManager.AddGame(new Game() { Id = 3, Name = "counter strike", Price = 300 });

            foreach (var game in gameManager.ListGames())
                Console.WriteLine(game.Name);

            standartSaleManager.SellGame(studentManager.GetStudentById(1), gameManager.GetGameById(1));
            discountSaleManager.SellGame(studentManager.GetStudentById(2), gameManager.GetGameById(2));

        }
    }
}
