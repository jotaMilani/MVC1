using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {

            Aluno a1 = new Aluno(1, "João Pedro", "batata1@gmail.com", 1234);
            Aluno a2 = new Aluno(2, "João Paulo", "batata12@gmail.com", 12345);
            Aluno a3 = new Aluno(3, "João Baltazar", "batata123@gmail.com", 123456);
            Aluno a4 = new Aluno(4, "João Lucas", "batata1234@gmail.com", 1234567);
            Aluno a5 = new Aluno(5, "João Tiago", "batata12345@gmail.com", 12345678);

            List<Aluno> listAlunos = new List<Aluno>();

            listAlunos.Add(a1);
            listAlunos.Add(a2);
            listAlunos.Add(a3);
            listAlunos.Add(a4);
            listAlunos.Add(a5);

            return View(listAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }



    }
}
