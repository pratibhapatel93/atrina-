﻿using System;
namespace properties
{
    public class Student
    {
        private int _id;
        private string _Name;

        private int _passmarks = 35;

        public void SetName(string Name)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null");
            }
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this. _Name)? "No Name" : this ._Name;
        }

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception ("Student Id cannot be negative ");
            }
            this._id=Id;
        }
       
        public int GetId()
        {
            return this._id;
        } 
        public int Getpassmarks()
        {
            return this._passmarks ;
        } 



    } 
    
    public class Program
    {
    public static void Main()
    {
        Student C1= new Student();
        C1.SetId(101);
        C1.SetName("Atrina");

        Console.WriteLine("Student Id = {0}", C1.GetId());
        Console.WriteLine("Student Name={0}", C1.GetName());
        Console.WriteLine("Student passmarsk={0}", C1.Getpassmarks());
    }
    }
}
