﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNET.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public decimal Grant { get; set; }
        public int GroupId { get; set; }


        public override string ToString()
        {
            return $"{Id} {Fullname} {Grant} {GroupId}";
        }
    }
}
