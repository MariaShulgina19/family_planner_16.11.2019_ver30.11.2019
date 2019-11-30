using System;

namespace family_planner_16._11._2019
{
    internal class NpgsqlConnection
    {
        private string v;

        public NpgsqlConnection(string v)
        {
            this.v = v;
        }

       
        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            Console.WriteLine("could not find  ");
            throw new NotImplementedException();
        }

    
    }
}