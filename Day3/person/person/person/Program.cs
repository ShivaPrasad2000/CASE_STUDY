using System;

namespace person
{
    class Details
    {
        string Name;
        string DOB;
        string address;
        bool maritalStatus;
        public Details(string Name, string DOB, string address, bool maritalStatus)
        {
            this.Name = Name;
            this.DOB = DOB;
            this.address = address;
            this.maritalStatus = maritalStatus;
        }
        public string Name1 { set; get; }
        public string Date { set; get; }
        public string Address { set; get; }
        public bool MaritalStatus { set; get; }
        public int GetAge()
        {
            string date = DOB;
            DateTime date1 = Convert.ToDateTime(DOB);
            int age = 0;
            age = DateTime.Now.Subtract(date1).Days;
            age = age / 365;
            return age;
        }
        public bool canMarry()
        {
            if (GetAge() > 18 && maritalStatus.Equals(0))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return ($"{Name} , {DOB} , {address} ,{MaritalStatus}");
        }
    }
    class progarm {
        static void Main(string[] args)
        {
            Details d = new Details("shiva", "23/1/1990", "address1", false);
            Console.WriteLine(d.GetAge());
            Console.WriteLine(d.ToString());
        }
    }
}
