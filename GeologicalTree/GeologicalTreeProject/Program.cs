using System;
using GeologicalTreeProject.Persons;

namespace GeologicalTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача: 
            // 1. Реализовать генеалогическое дерево, так чтобы родители знали о детях, а дети о родителях.
            // 2. Найти человека с фамилией "Пупкин".


            Person<Ancestor> ancestors = new Person<Ancestor>() { FirstName = "Dmitry", LastName = "Petrov" };
            ancestors.Right = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Ivan", LastName = "Petrov", Parent = ancestors };
            ancestors.Left = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Anna", LastName = "Lee", Parent = ancestors };
            ancestors.Right.Right = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Oleg", LastName = "Petrov", Parent = ancestors.Right };
            ancestors.Right.Left = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Alla", LastName = "Vlasova", Parent = ancestors.Left };
            ancestors.Left.Right = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Oleg", LastName = "Perevyazko", Parent = ancestors.Left };
            ancestors.Right.Left = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Inga", LastName = "Krilova", Parent = ancestors.Right };
            ancestors.Left.Left = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Dariya", LastName = "Ivanova", Parent = ancestors.Left };
            ancestors.Right.Right.Right = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Olif", LastName = "Petrov", Parent = ancestors.Right.Right };
            ancestors.Right.Right.Left = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Irina", LastName = "Makarenko", Parent = ancestors.Right.Right };
            ancestors.Left.Right.Left = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Yana", LastName = "Krilenko", Parent = ancestors.Left.Right };
            ancestors.Left.Right.Right = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Petr", LastName = "Pupkin", Parent = ancestors.Left.Right };
            ancestors.Left.Left.Right = new Relatives<Ancestor>(new Ancestor()) { FirstName = "Ilya", LastName = "Koryakin", Parent = ancestors.Left.Left };

            
        }
    }
}

