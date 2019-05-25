using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;
        private int id = 0;
        public int Count {
        get
        { return this.data.Count(); }
        }
        public Repository()
        {
            this.data = new Dictionary<int, Person>();
        }
        public void Add(Person person)
        {
            this.data.Add(id, person);
            id++;
        }
        public Person Get(int id)
        {
            return data.ElementAt(id).Value;
        }
        public bool Update(int id, Person newPerson)    
        {
            if (data.ContainsKey(id))
            {
                data[id] = newPerson;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            if (data.ContainsKey(id))
            {
                data.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
