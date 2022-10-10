using AulaEF_CodeFirst.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEF_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                #region INSERE DADOS
                //context.Persons.Add(new Person() { Name = "Maicon Rodrigues", Phone = "16988144127" });
                //context.Persons.Add(new Person() { Name = "Thais Keli", Phone = "1698814238" });

                Person p = new Person();

                p.Name = "Baratao";
                p.Mail = "baratox@raid.com.br";
                p.Phone = "33334412";
                p.Mobile = "1699616783";

                context.Persons.Add(p);
                context.SaveChanges();
                #endregion

                #region IMPRIMIR TODOS
                var persons = new PersonContext().Persons.ToList();
                foreach (var item in persons)
                {
                    Console.WriteLine(item.ToString());
                }

                #endregion

                #region IMPRIMIR UM
                string n = Console.ReadLine();
                Person find = new PersonContext().Persons.FirstOrDefault(f => f.Name == n);
                if(find != null)
                context.SaveChanges();
                Console.WriteLine(find.ToString());
                
                #endregion

                #region REMOVE
                //context.Entry(find).State = EntityState.Deleted;
                //context.Persons.Remove(find);
                #endregion

                #region UPDATE
                find.Name = "Maicoooonnnn";
                context.Entry(find).State = EntityState.Modified;
                context.SaveChanges();
                Console.WriteLine(find.ToString());
                #endregion

                Console.ReadKey();
            }

        }
    }
}