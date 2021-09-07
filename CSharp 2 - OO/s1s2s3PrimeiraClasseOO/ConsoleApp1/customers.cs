using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank
{
    public class customers
    {
        private string customerName;
        private string customerDocument;
        private string customerBirthday;
        private string customerCountry;
        private string customerAddress;

        public void set_customerName(string name)
        {
            this.customerName = name;
        }
        public void set_customerDocument(string document)
        {
            this.customerDocument = document;
        }
        public void set_customerBirthday(string birthday)
        {
            this.customerBirthday = birthday;
        }
        public void set_customerCountry(string country)
        {
            this.customerCountry = country;
        }
        public void set_customerAddress(string address)
        {
            this.customerAddress = address;
        }

        public string get_customerName()
        {
            return this.customerName;
        }
        public string get_customerDocument()
        {
            return this.customerDocument;
        }
        public string get_ccustomerBirthday()
        {
            return this.customerBirthday;
        }
        public string get_customerCountry()
        {
            return this.customerCountry;
        }
        public string get_customerAddress()
        {
            return this.customerAddress;
        }
    }


}
