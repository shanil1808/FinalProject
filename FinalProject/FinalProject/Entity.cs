using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Entity
    {
        private int id;
        private string name;
        DateTime createdDate;

        public Entity(int id, string name, DateTime createdDate)
        {
            this.id = id;
            this.name = name;
            this.createdDate = createdDate;
        }
        public int GetId() { return id; }

        public string GetName() { return name; }

        public DateTime GetCreatedDate() { return createdDate; }

        public void SetName(string name)
        {
            if (name == null) throw new ArgumentNullException("name"); 
            this.name = name;
        }

        public void SetCreatedDate(DateTime dateTime) 
        { 
            this.createdDate = dateTime; 
        }

        public virtual bool Validate()
        {
            if (name == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public abstract void Display();
    }
}
