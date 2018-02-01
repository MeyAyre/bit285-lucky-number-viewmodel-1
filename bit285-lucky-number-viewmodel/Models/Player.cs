using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bit285_lucky_number_viewmodel.Models
{
    public class Player
    {
        //TODO: Add the properties neededby the Player entity (including Data Annotations)
        public int ID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Number { get; set; }
    }
}