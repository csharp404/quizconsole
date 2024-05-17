using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Applicants
    {
       
        public string name { set; get; }
        public int age { set; get; }
        private int score;

        public Applicants(string na,int age)
        {
           
            this.name = na; 
            this.age = age;
        }
        public void AddPoint() {
        score++;
        } 
        public int getScore() { return score; }

    }
}
