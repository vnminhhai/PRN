﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HE181099_Assignment1.Models;

namespace BussinessObjects.Repository
{
    public interface ICustomerRepository
    {
        public Customer GetCustomerByEmail(string email);
        public void UpdateCustomer(Customer customer);
    }
}
