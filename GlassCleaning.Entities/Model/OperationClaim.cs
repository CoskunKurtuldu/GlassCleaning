using GlassCleaning.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlassCleaning.Entities.Model
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
