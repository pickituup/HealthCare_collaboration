using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCare.Messages
{
    public class Message : IEntity<long> {

        public string Content { get; set; }

        public long Id { get; set; }

        public bool IsTransient() {
            return false;
        }
    }
}
