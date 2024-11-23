using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19._11.Entities
{
    internal class Website
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Ip { get; set; }

        Website()
        {
            Name = "Default";
            Url = "Default";
            Description = "Default";
            Ip = "Default";
        }

        public Website(string name) : this()
        {
            Name = name;
        }
        public Website(string name, string url) : this(name)
        {
            Url = url;
        }
        public Website(string name, string url, string description) : this(name, url)
        {
            Description = description;
        }
        public Website(string name, string url, string description, string ip) : this(name, url, description)
        {
            Ip = ip;
        }

        public string Print()
        {
            return $"Name: {Name}\nUrl: {Url}\nDescription: {Description}\nIp: {Ip}";
        }
    }
}
