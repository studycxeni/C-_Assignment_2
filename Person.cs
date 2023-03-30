using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2 {
    class Person {
        protected string name, lastName;
        protected int age;

        public Person (string name, string lastName, int age) {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

    }
    class Doctor : Person {
        string departmentName, position, hospitalName, experience;
        public Doctor (string name, string lastName, int age, string departmentName, string position, string hospitalName, string experience) : base (name, lastName, age) {
            this.departmentName = departmentName;
            this.position = position;
            this.hospitalName = hospitalName;
            this.experience = experience;
        }
        public void Print(Label label) {
            label.Text = String.Format("სახელი : {0} \n გვარი : {1} \n ასაკი : {2} \n განყოფილების დასახელება : {3} \n თანამდებობა : {4} \n" +
                "საავადმყოფოს დასახელება : {5} \n სტაჟი : {6} \n "
                , name, lastName, age, departmentName, position, hospitalName, experience);
        }
    }
}
