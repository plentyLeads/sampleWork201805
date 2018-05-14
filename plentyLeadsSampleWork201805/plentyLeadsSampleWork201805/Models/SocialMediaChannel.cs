using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace plentyLeadsSampleWork201805.Models
{
    [Serializable]
    public class SocialMediaChannel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }

        public SocialMediaChannel()
        {

        }
    }
}